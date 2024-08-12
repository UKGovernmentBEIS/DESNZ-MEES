import zipfile
from dotenv import load_dotenv
import os
from tqdm import tqdm

load_dotenv()

zip_file_names = [
    os.getenv('HMLR_CCOD_OUTPUT_FILE'),
    os.getenv('HMLR_OCOD_OUTPUT_FILE')
]


def unzip(zip_file):
    zip_dir = zip_file.replace('.zip', '')
    with zipfile.ZipFile(zip_file, 'r') as zip_re:
        for file in tqdm(zip_re.infolist()):
            zip_re.extract(file, zip_dir)


for file_name in zip_file_names:
    unzip(file_name)
#%%
