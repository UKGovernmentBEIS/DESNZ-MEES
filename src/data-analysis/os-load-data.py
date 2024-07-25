import urllib.request
from urllib.parse import urlencode
from dotenv import load_dotenv
import os

load_dotenv()

token = os.getenv('OS_TOKEN')
output_file = os.getenv('OS_OUTPUT_FILE')
base_url = os.getenv('OS_BASE_URL')
query_params = {'fileName': output_file, 'key': token}

