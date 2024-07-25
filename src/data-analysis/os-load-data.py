import urllib.request
from urllib.parse import urlencode
from dotenv import load_dotenv
import os
import progressbar

load_dotenv()

token = os.getenv('OS_TOKEN')
output_file = os.getenv('OS_OUTPUT_FILE')
base_url = os.getenv('OS_BASE_URL')
full_url = f'{base_url}{token}'
pbar = None


def show_progress(block_num, block_size, total_size):
    global pbar
    if pbar is None:
        pbar = progressbar.ProgressBar(maxval=total_size)
        pbar.start()

    downloaded = block_num * block_size
    if downloaded < total_size:
        pbar.update(downloaded)
    else:
        pbar.finish()
        pbar = None


opener = urllib.request.build_opener()
urllib.request.install_opener(opener)
urllib.request.urlretrieve(full_url, output_file, show_progress)
# 14% after 2hrs
#%%
