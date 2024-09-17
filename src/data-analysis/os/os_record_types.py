import collections
import polars as pl

RecordTypeInfo = collections.namedtuple('RecordTypeInfo', ['PrimaryKey', 'PkDtype', 'ColNames', 'TableName'])

record_types = {
    11: RecordTypeInfo('usrn', pl.Int16, ['record_identifier', 'change_type', 'pro_order', 'usrn', 'record_type', 'swa_org_ref_naming', 'state', 'state_date', 'street_surface', 'street_classification', 'version', 'street_start_date', 'street_end_date', 'last_update_date', 'record_entry_date', 'street_start_x', 'street_start_y', 'street_start_lat', 'street_start_long', 'street_end_x', 'street_end_y', 'street_end_lat', 'street_end_long', 'street_tolerance'], 'abp_street'),
    15: RecordTypeInfo('usrn', pl.Int16, ['record_identifier', 'change_type', 'pro_order', 'usrn', 'street_description', 'locality', 'town_name', 'administrative_area', 'language', 'start_date', 'end_date', 'last_update_date', 'entry_date'], 'abp_street_descriptor'),
    21: RecordTypeInfo('uprn', pl.Int16, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'logical_status', 'blpu_state', 'blpu_state_date', 'parent_uprn', 'x_coordinate', 'y_coordinate', 'latitude', 'longitude', 'rpc', 'local_custodian_code', 'country', 'start_date', 'end_date', 'last_update_date', 'entry_date', 'addressbase_postal', 'postcode_locator', 'multi_occ_count'], 'abp_blpu'),
    23: RecordTypeInfo('xref_key', pl.String, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'xref_key', 'cross_reference', 'version', 'source', 'start_date', 'end_date', 'last_update_date', 'entry_date'], 'abp_crossref'),
    24: RecordTypeInfo('lpi_key', pl.String, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'lpi_key', 'language', 'logical_status', 'start_date', 'end_date', 'last_update_date', 'entry_date', 'sao_start_number', 'sao_start_suffix', 'sao_end_number', 'sao_end_suffix', 'sao_text', 'pao_start_number', 'pao_start_suffix', 'pao_end_number', 'pao_end_suffix', 'pao_text', 'usrn', 'usrn_match_indicator', 'area_name', 'level', 'official_flag'], 'abp_lpi'),
    28: RecordTypeInfo('udprn', pl.Int16, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'udprn', 'organisation_name', 'department_name', 'sub_building_name', 'building_name', 'building_number', 'dependant_thoroughfare', 'thoroughfare', 'double_dependant_locality', 'dependant_locality', 'post_town', 'postcode', 'postcode_type', 'delivery_point_suffix', 'welsh_dependant_thoroughfare', 'welsh_thoroughfare', 'welsh_double_dependant_locality', 'welsh_dependant_locality', 'welsh_post_town', 'po_box_number', 'process_date', 'start_date', 'end_date', 'last_update_date', 'entry_date'], 'abp_delivery_point'),
    30: RecordTypeInfo('succ_key', pl.String, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'succ_key', 'start_date', 'end_date', 'last_update_date', 'entry_date', 'successor'], 'abp_successor'),
    31: RecordTypeInfo('org_key', pl.String, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'org_key', 'organisation', 'legal_name', 'start_date', 'end_date', 'last_update_date', 'entry_date'], 'abp_organisation'),
    32: RecordTypeInfo('class_key', pl.String, ['record_identifier', 'change_type', 'pro_order', 'uprn', 'class_key', 'classification_code', 'class_scheme', 'scheme_version', 'start_date', 'end_date', 'last_update_date', 'entry_date'], 'abp_classification')
}