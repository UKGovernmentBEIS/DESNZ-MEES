#!/bin/bash
epc_source_url="https://epc.opendatacommunities.org/files/all-non-domestic-certificates.zip"
epc_dest_file="$HOME/dev/mees-alpha/src/data-analysis/downloads/epc-register.csv.zip"
wget "$epc_source_url" -0 "$epc_dest_file" #note missing auth header
unzip "$epc_dest_file"
del "$epc_dest_file"

