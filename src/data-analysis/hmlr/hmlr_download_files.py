import requests
from dotenv import load_dotenv
import os
from tqdm import tqdm

load_dotenv()

token = os.getenv('HMLR_TOKEN')
ccod_output_file = os.getenv('HMLR_CCOD_OUTPUT_FILE')
ocod_output_file = os.getenv('HMLR_OCOD_OUTPUT_FILE')
ccod_base_url = os.getenv('HMLR_CCOD_BASE_URL')
ocod_base_url = os.getenv('HMLR_OCOD_BASE_URL')


def get_file_address(url):
    headers = {
        'Authorization': f'{token}',
        'Accept': 'application/json'
    }
    http_response = requests.get(url, headers=headers)
    if http_response.status_code == 200:
        json_response = http_response.json()
        return json_response['result']['download_url']
    else:
        raise Exception(f'Failed to get file address for {url}')


def download_file(url, file_name):
    file_open_mode = 'wb'
    if os.path.exists(file_name):
        file_open_mode = 'ab'
        # create a resume_header and pass that to requests.get()
        # - resume_header= {'Range': 'bytes=%d-' % resume_byte_pos}
    with requests.get(url, stream=True) as r:
        total_size = int(r.headers.get('content-length', 0))
        block_size = 1024 * 8
        r.raise_for_status()
        with tqdm(total=total_size, unit='B', unit_scale=True, unit_divisor=block_size) as pbar:
            with open(file_name, file_open_mode) as f:
                for chunk in r.iter_content(chunk_size=block_size):
                    pbar.update(len(chunk))
                    f.write(chunk)
        if total_size != 0 and pbar.n != total_size:
            raise RuntimeError("Failed to download file")

    return


ccod_file_url = get_file_address(ccod_base_url)
download_file(ccod_file_url, ccod_output_file)

ocod_file_url = get_file_address(ocod_base_url)
download_file(ocod_file_url, ocod_output_file)
#%%
