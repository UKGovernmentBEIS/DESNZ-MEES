import urllib.request
from urllib.parse import urlencode
from dotenv import load_dotenv
import os

load_dotenv()

token = os.getenv('EPC_TOKEN')
page_size = os.getenv('EPC_PAGE_SIZE')
output_file = os.getenv('EPC_OUTPUT_FILE')
base_url = os.getenv('EPC_BASE_URL')
query_params = {'size': page_size}

headers = {
    'Accept': 'text/csv',
    'Authorization': f'Basic {token}'
}

first_request = True
search_after = None

with open(output_file, 'w') as csvfile:
    while search_after is not None or first_request:
        if not first_request:
            query_params["search-after"] = search_after
        encoded_params = urlencode(query_params)
        full_url = f'{base_url}?{encoded_params}'

        with urllib.request.urlopen(urllib.request.Request(full_url, headers=headers)) as response:
            response_body = response.read()
            body = response_body.decode('utf-8')
            search_after = response.getheader('X-Next-Search-After')

        if not first_request and body != "":
            body = body.split("\n", 1)[1]

        csvfile.write(body)
        first_request = False

        print(search_after)
        # takes approx 10min

#%%
