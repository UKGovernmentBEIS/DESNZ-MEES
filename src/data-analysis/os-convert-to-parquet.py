import polars as pl
from dotenv import load_dotenv
import os
from datetime import datetime
load_dotenv()

# load OS
os_files_path = os.getenv('OS_FILES_PATH')
csv_file_names = sorted(os.listdir(os_files_path))

record_dfs = {}
record_types = [21,23,28,31,32]

# read each file and assign to correct os record type
for file_name in csv_file_names:
    record_type = int(file_name[2:4])
    if record_type not in record_types: continue
    print(f'file_name: [{file_name}], time: [{datetime.now().strftime("%H:%M:%S")}]')
    temp_df = pl.read_csv(f'{os_files_path}/{file_name}', infer_schema_length=0)
    record_dfs[record_type] = temp_df

print('done')

# save to parquet files
os.makedirs('output', exist_ok=True)
for record_type in record_dfs.keys():
    print(f'type: [{record_type}], time: [{datetime.now().strftime("%H:%M:%S")}]')
    record_dfs[record_type].write_parquet(f'output/os_recordtype_{record_type}.parquet')
#%%
