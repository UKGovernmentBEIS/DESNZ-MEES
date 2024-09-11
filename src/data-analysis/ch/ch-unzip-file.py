import zipfile
from dotenv import load_dotenv
import os
from tqdm import tqdm

load_dotenv()

zip_file_name = os.getenv('CH_OUTPUT_FILE')
root_dir = os.getenv('DOWNLOADS_FOLDER')


def unzip(zip_file):
    zip_file_path = f'{root_dir}/{zip_file}'
    zip_dir = f'{root_dir}/{zip_file_name.replace(".zip", "")}'
    with zipfile.ZipFile(zip_file_path, 'r') as zip_re:
        for file in tqdm(zip_re.infolist()):
            zip_re.extract(file, zip_dir)


unzip(zip_file_name)
#%%
