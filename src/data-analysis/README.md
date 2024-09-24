# DESNZ-MEES Alpha - Data Analysis

## Warning
This is experimental code and not intended for commercial use.

## How it Works
This is a collection of python and jupyter scripts that can be run to automate the

- downloading (`XX_download_files.py`)
- unzipping (`XX_unzip-file.py`)
- analysis (`XX-analysis.ipynb`)
- conversion to parquet (`XX-create-parquets.ipynb`)

of data from a variety of sources (see Confluence or HLD for more info on each of the data sources) that together provide the required data to identify non-domestic, rented properties that are below the Minimum Energy Efficiency Standard (MEES).

The folder structure organises each of the data sources by their respsective source organisation, for example hmlr contains ccod, ocod and poly-mock data sources. Note, this rearrangement into sub-folders has broken some paths.

There is one more important file, `all-db-import.ipynb`, which loads each parquet file into a destination DB.

The intention of this code is not only to get a POC working but also to provide a head start for building this functionality in DMS on Databricks and using `polars`. Therefore polars was used as the data analysis library (tho pandas was used until I found out that DMS uses polars).

## Installation
### Pre-requisites
- Python runtime
- Jupyter Server

I found it much easier to install and run these on a mac than windows machine. Even using WSL on windows it was still painful.

### Config
- Copy the dev.env file to an .env file. You will have to populate this file with any missing values for specific paths, keys, tokens etc.

## Local Running
- Due to the size of the files downloaded you will need a lot of diskspace. It is currently using `60GB`(!!) on my local. Once you have the parquet files you could delete everything from the downloads dir, unless you need them for further data matching activities, which I did. Please be careful to keep `.gitignore` updated so these huge files are not committed to the repo.
- Also due to the size of the files some of the operations did take a long time. Building the poly-mock data was one of the longest, it ran overnight.
## External Dependencies
- Each of the data imports will require an account created in order to gain a token for access.
## Technologies
- Python
- Polars
- Jupyter
## Known Issues
- no attempt has been made to get the correct file download per month. Currently the most recent at the time of writing was hardcoded.
- VOA data is meant to be augmented with updates, this was not done.
- use of subfolders for each script has broken some of the paths. Prepending with '../' should resolve the issue in most cases. At the same time you should start using the 'OUTPUT_FOLDER' and 'DOWNLOADS_FOLDER' env variables so that the scripts are more robust between environments.
- the `XX-create-parquets.ipynb` files can easily be converted to py files but this has not been done. It was helpful when running in Jupyter to debug what was going on.
- the resultant DB from `all-db-import.ipynb` has most of the columns set to `text` data type and no indexes or keys. Setting the types, indexes and keys will drastically improve query performance. This was done to a point but abandoned due to time constraints.