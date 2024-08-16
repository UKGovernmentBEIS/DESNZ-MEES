import requests
from dotenv import load_dotenv
import os
from tqdm import tqdm

load_dotenv()

output_file = os.getenv('CH_OUTPUT_FILE')
output_file_and_path = f'downloads/{output_file}'
base_url = os.getenv('CH_BASE_URL')
full_url = base_url


def download_file(url, file_name):
    file_open_mode = 'wb'
    if os.path.exists(file_name):
        file_open_mode = 'ab'
        # and resume from, like pycurls c.setopt(c.RESUME_FROM, os.path.getsize(file_name))
        # create a resume_header and pass that to requests.get() - resume_header= {'Range': 'bytes=%d-' % resume_byte_pos}
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


download_file(full_url, output_file_and_path)
#%%
