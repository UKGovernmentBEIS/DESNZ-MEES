import polars as pl
import numpy as np
from dotenv import load_dotenv
import os
from datetime import datetime
import os_record_types as os_records
load_dotenv()

# load OS
zip_file_name = os.getenv('OS_FILENAME')
zip_dir = zip_file_name.replace('.zip', '')
csv_file_names = sorted(os.listdir(zip_dir))

record_dfs = {}
schema = {}
for i in range(30):
    schema[str(i)] = pl.String

# read each file and assign to correct os record type
for file_name in csv_file_names:
    print(f'file_name: [{file_name}], time: [{datetime.now().strftime("%H:%M:%S")}]')
    # temp_df = pl.read_csv(f'{zip_dir}/{file_name}', header=None, names=range(30), dtype=object)
    temp_df = pl.read_csv(f'{zip_dir}/{file_name}', has_header=False, schema=schema)
    # build individual dfs
    for record_type in os_records.record_types.keys():
        records_to_add = temp_df.filter(pl.col('0') == str(record_type))
        count = len(records_to_add)
        print(f'record_type: [{record_type}], time: [{datetime.now().strftime("%H:%M:%S")}], count: {count}')
        if count == 0: continue
        if record_type in record_dfs:
            record_dfs[record_type] = pl.concat([record_dfs[record_type], records_to_add])
        else:
            record_dfs[record_type] = records_to_add

print('done')

# remove excess cols
for record_type in record_dfs.keys():
    if record_dfs[record_type].is_empty(): continue
    df_null_cols = record_dfs[record_type].select(pl.all().is_null().all())
    columns_to_drop = (df_null_cols
                       .unpivot()
                       .filter(pl.col('value')==True)['variable']
                       .to_list())
    print(f'type: [{record_type}], time: [{datetime.now().strftime("%H:%M:%S")}], cols_to_drop: [{columns_to_drop}]')
    record_dfs[record_type] = record_dfs[record_type].drop(columns_to_drop)

# add col names
for record_type in record_dfs.keys():
    print(f'type: [{record_type}], time: [{datetime.now().strftime("%H:%M:%S")}]')
    record_dfs[record_type].columns = os_records.record_types[record_type].ColNames

# save to parquet files
os.makedirs('output', exist_ok=True)
for record_type in record_dfs.keys():
    print(f'type: [{record_type}], time: [{datetime.now().strftime("%H:%M:%S")}]')
    record_dfs[record_type].write_parquet(f'output/os_recordtype_{record_type}.parquet')
#%%
