using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Desnz.Mees.DataTool.Data;

public partial class DataToolContext : DbContext
{
    public DataToolContext()
    {
    }

    public DataToolContext(DbContextOptions<DataToolContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ChCompany> ChCompanies { get; set; }

    public virtual DbSet<EpcNonDomestic> EpcNonDomestics { get; set; }

    public virtual DbSet<EpcToUprn> EpcToUprns { get; set; }

    public virtual DbSet<HmlrCcod> HmlrCcods { get; set; }

    public virtual DbSet<HmlrOcod> HmlrOcods { get; set; }

    public virtual DbSet<HmlrPolyTitleToUprn> HmlrPolyTitleToUprns { get; set; }

    public virtual DbSet<OsRecordtype21> OsRecordtype21s { get; set; }

    public virtual DbSet<OsRecordtype23> OsRecordtype23s { get; set; }

    public virtual DbSet<OsRecordtype24> OsRecordtype24s { get; set; }

    public virtual DbSet<OsRecordtype28> OsRecordtype28s { get; set; }

    public virtual DbSet<OsRecordtype31> OsRecordtype31s { get; set; }

    public virtual DbSet<OsRecordtype32> OsRecordtype32s { get; set; }

    public virtual DbSet<VoaBusinessRate> VoaBusinessRates { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Connection String");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ChCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ch-company");

            entity.Property(e => e.AccountsAccountCategory).HasColumnName("Accounts.AccountCategory");
            entity.Property(e => e.AccountsAccountRefDay).HasColumnName("Accounts.AccountRefDay");
            entity.Property(e => e.AccountsAccountRefMonth).HasColumnName("Accounts.AccountRefMonth");
            entity.Property(e => e.AccountsLastMadeUpDate).HasColumnName("Accounts.LastMadeUpDate");
            entity.Property(e => e.AccountsNextDueDate).HasColumnName("Accounts.NextDueDate");
            entity.Property(e => e.CompanyNumber).HasColumnName(" CompanyNumber");
            entity.Property(e => e.ConfStmtLastMadeUpDate).HasColumnName(" ConfStmtLastMadeUpDate");
            entity.Property(e => e.LimitedPartnershipsNumGenPartners).HasColumnName("LimitedPartnerships.NumGenPartners");
            entity.Property(e => e.LimitedPartnershipsNumLimPartners).HasColumnName("LimitedPartnerships.NumLimPartners");
            entity.Property(e => e.MortgagesNumMortCharges).HasColumnName("Mortgages.NumMortCharges");
            entity.Property(e => e.MortgagesNumMortOutstanding).HasColumnName("Mortgages.NumMortOutstanding");
            entity.Property(e => e.MortgagesNumMortPartSatisfied).HasColumnName("Mortgages.NumMortPartSatisfied");
            entity.Property(e => e.MortgagesNumMortSatisfied).HasColumnName("Mortgages.NumMortSatisfied");
            entity.Property(e => e.PreviousName10CompanyName).HasColumnName(" PreviousName_10.CompanyName");
            entity.Property(e => e.PreviousName10Condate).HasColumnName("PreviousName_10.CONDATE");
            entity.Property(e => e.PreviousName1CompanyName).HasColumnName(" PreviousName_1.CompanyName");
            entity.Property(e => e.PreviousName1Condate).HasColumnName("PreviousName_1.CONDATE");
            entity.Property(e => e.PreviousName2CompanyName).HasColumnName(" PreviousName_2.CompanyName");
            entity.Property(e => e.PreviousName2Condate).HasColumnName(" PreviousName_2.CONDATE");
            entity.Property(e => e.PreviousName3CompanyName).HasColumnName(" PreviousName_3.CompanyName");
            entity.Property(e => e.PreviousName3Condate).HasColumnName("PreviousName_3.CONDATE");
            entity.Property(e => e.PreviousName4CompanyName).HasColumnName(" PreviousName_4.CompanyName");
            entity.Property(e => e.PreviousName4Condate).HasColumnName("PreviousName_4.CONDATE");
            entity.Property(e => e.PreviousName5CompanyName).HasColumnName(" PreviousName_5.CompanyName");
            entity.Property(e => e.PreviousName5Condate).HasColumnName("PreviousName_5.CONDATE");
            entity.Property(e => e.PreviousName6CompanyName).HasColumnName(" PreviousName_6.CompanyName");
            entity.Property(e => e.PreviousName6Condate).HasColumnName("PreviousName_6.CONDATE");
            entity.Property(e => e.PreviousName7CompanyName).HasColumnName(" PreviousName_7.CompanyName");
            entity.Property(e => e.PreviousName7Condate).HasColumnName("PreviousName_7.CONDATE");
            entity.Property(e => e.PreviousName8CompanyName).HasColumnName(" PreviousName_8.CompanyName");
            entity.Property(e => e.PreviousName8Condate).HasColumnName("PreviousName_8.CONDATE");
            entity.Property(e => e.PreviousName9CompanyName).HasColumnName(" PreviousName_9.CompanyName");
            entity.Property(e => e.PreviousName9Condate).HasColumnName("PreviousName_9.CONDATE");
            entity.Property(e => e.RegAddressAddressLine1).HasColumnName("RegAddress.AddressLine1");
            entity.Property(e => e.RegAddressAddressLine2).HasColumnName(" RegAddress.AddressLine2");
            entity.Property(e => e.RegAddressCareOf).HasColumnName("RegAddress.CareOf");
            entity.Property(e => e.RegAddressCountry).HasColumnName("RegAddress.Country");
            entity.Property(e => e.RegAddressCounty).HasColumnName("RegAddress.County");
            entity.Property(e => e.RegAddressPobox).HasColumnName("RegAddress.POBox");
            entity.Property(e => e.RegAddressPostCode).HasColumnName("RegAddress.PostCode");
            entity.Property(e => e.RegAddressPostTown).HasColumnName("RegAddress.PostTown");
            entity.Property(e => e.ReturnsLastMadeUpDate).HasColumnName("Returns.LastMadeUpDate");
            entity.Property(e => e.ReturnsNextDueDate).HasColumnName("Returns.NextDueDate");
            entity.Property(e => e.SiccodeSicText1).HasColumnName("SICCode.SicText_1");
            entity.Property(e => e.SiccodeSicText2).HasColumnName("SICCode.SicText_2");
            entity.Property(e => e.SiccodeSicText3).HasColumnName("SICCode.SicText_3");
            entity.Property(e => e.SiccodeSicText4).HasColumnName("SICCode.SicText_4");
            entity.Property(e => e.Uri).HasColumnName("URI");
        });

        modelBuilder.Entity<EpcNonDomestic>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("epc-non-domestic");

            entity.Property(e => e.AcInspectionCommissioned).HasColumnName("ac-inspection-commissioned");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Address1).HasColumnName("address1");
            entity.Property(e => e.Address2).HasColumnName("address2");
            entity.Property(e => e.Address3).HasColumnName("address3");
            entity.Property(e => e.AirconKwRating).HasColumnName("aircon-kw-rating");
            entity.Property(e => e.AirconPresent).HasColumnName("aircon-present");
            entity.Property(e => e.AssetRating).HasColumnName("asset-rating");
            entity.Property(e => e.AssetRatingBand).HasColumnName("asset-rating-band");
            entity.Property(e => e.BuildingEmissions).HasColumnName("building-emissions");
            entity.Property(e => e.BuildingEnvironment).HasColumnName("building-environment");
            entity.Property(e => e.BuildingLevel).HasColumnName("building-level");
            entity.Property(e => e.BuildingReferenceNumber).HasColumnName("building-reference-number");
            entity.Property(e => e.Constituency).HasColumnName("constituency");
            entity.Property(e => e.ConstituencyLabel).HasColumnName("constituency-label");
            entity.Property(e => e.County).HasColumnName("county");
            entity.Property(e => e.EstimatedAirconKwRating).HasColumnName("estimated-aircon-kw-rating");
            entity.Property(e => e.ExistingStockBenchmark).HasColumnName("existing-stock-benchmark");
            entity.Property(e => e.FloorArea).HasColumnName("floor-area");
            entity.Property(e => e.InspectionDate).HasColumnName("inspection-date");
            entity.Property(e => e.LmkKey).HasColumnName("lmk-key");
            entity.Property(e => e.LocalAuthority).HasColumnName("local-authority");
            entity.Property(e => e.LocalAuthorityLabel).HasColumnName("local-authority-label");
            entity.Property(e => e.LodgementDate).HasColumnName("lodgement-date");
            entity.Property(e => e.LodgementDatetime)
                .HasColumnType("timestamp without time zone")
                .HasColumnName("lodgement-datetime");
            entity.Property(e => e.MainHeatingFuel).HasColumnName("main-heating-fuel");
            entity.Property(e => e.NewBuildBenchmark).HasColumnName("new-build-benchmark");
            entity.Property(e => e.OtherFuelDesc).HasColumnName("other-fuel-desc");
            entity.Property(e => e.Postcode).HasColumnName("postcode");
            entity.Property(e => e.Posttown).HasColumnName("posttown");
            entity.Property(e => e.PrimaryEnergyValue).HasColumnName("primary-energy-value");
            entity.Property(e => e.PropertyType).HasColumnName("property-type");
            entity.Property(e => e.RenewableSources).HasColumnName("renewable-sources");
            entity.Property(e => e.SpecialEnergyUses).HasColumnName("special-energy-uses");
            entity.Property(e => e.StandardEmissions).HasColumnName("standard-emissions");
            entity.Property(e => e.TargetEmissions).HasColumnName("target-emissions");
            entity.Property(e => e.TransactionType).HasColumnName("transaction-type");
            entity.Property(e => e.TypicalEmissions).HasColumnName("typical-emissions");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
            entity.Property(e => e.UprnSource).HasColumnName("uprn-source");
        });

        modelBuilder.Entity<EpcToUprn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("epc-to-uprn");

            entity.Property(e => e.LmkKey).HasColumnName("lmk-key");
            entity.Property(e => e.Score).HasColumnName("score");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
        });

        modelBuilder.Entity<HmlrCcod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hmlr-ccod");

            entity.Property(e => e.AdditionalProprietorIndicator).HasColumnName("Additional Proprietor Indicator");
            entity.Property(e => e.CompanyRegistrationNo1).HasColumnName("Company Registration No. (1)");
            entity.Property(e => e.CompanyRegistrationNo2).HasColumnName("Company Registration No. (2)");
            entity.Property(e => e.CompanyRegistrationNo3).HasColumnName("Company Registration No. (3)");
            entity.Property(e => e.CompanyRegistrationNo4).HasColumnName("Company Registration No. (4)");
            entity.Property(e => e.DateProprietorAdded).HasColumnName("Date Proprietor Added");
            entity.Property(e => e.MultipleAddressIndicator).HasColumnName("Multiple Address Indicator");
            entity.Property(e => e.PricePaid).HasColumnName("Price Paid");
            entity.Property(e => e.PropertyAddress).HasColumnName("Property Address");
            entity.Property(e => e.Proprietor1Address1).HasColumnName("Proprietor (1) Address (1)");
            entity.Property(e => e.Proprietor1Address2).HasColumnName("Proprietor (1) Address (2)");
            entity.Property(e => e.Proprietor1Address3).HasColumnName("Proprietor (1) Address (3)");
            entity.Property(e => e.Proprietor2Address1).HasColumnName("Proprietor (2) Address (1)");
            entity.Property(e => e.Proprietor2Address2).HasColumnName("Proprietor (2) Address (2)");
            entity.Property(e => e.Proprietor2Address3).HasColumnName("Proprietor (2) Address (3)");
            entity.Property(e => e.Proprietor3Address1).HasColumnName("Proprietor (3) Address (1)");
            entity.Property(e => e.Proprietor3Address2).HasColumnName("Proprietor (3) Address (2)");
            entity.Property(e => e.Proprietor3Address3).HasColumnName("Proprietor (3) Address (3)");
            entity.Property(e => e.Proprietor4Address1).HasColumnName("Proprietor (4) Address (1)");
            entity.Property(e => e.Proprietor4Address2).HasColumnName("Proprietor (4) Address (2)");
            entity.Property(e => e.Proprietor4Address3).HasColumnName("Proprietor (4) Address (3)");
            entity.Property(e => e.ProprietorName1).HasColumnName("Proprietor Name (1)");
            entity.Property(e => e.ProprietorName2).HasColumnName("Proprietor Name (2)");
            entity.Property(e => e.ProprietorName3).HasColumnName("Proprietor Name (3)");
            entity.Property(e => e.ProprietorName4).HasColumnName("Proprietor Name (4)");
            entity.Property(e => e.ProprietorshipCategory1).HasColumnName("Proprietorship Category (1)");
            entity.Property(e => e.ProprietorshipCategory2).HasColumnName("Proprietorship Category (2)");
            entity.Property(e => e.ProprietorshipCategory3).HasColumnName("Proprietorship Category (3)");
            entity.Property(e => e.ProprietorshipCategory4).HasColumnName("Proprietorship Category (4)");
            entity.Property(e => e.TitleNumber).HasColumnName("Title Number");
        });

        modelBuilder.Entity<HmlrOcod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hmlr-ocod");

            entity.Property(e => e.AdditionalProprietorIndicator).HasColumnName("Additional Proprietor Indicator");
            entity.Property(e => e.CompanyRegistrationNo1).HasColumnName("Company Registration No. (1)");
            entity.Property(e => e.CompanyRegistrationNo2).HasColumnName("Company Registration No. (2)");
            entity.Property(e => e.CompanyRegistrationNo3).HasColumnName("Company Registration No. (3)");
            entity.Property(e => e.CompanyRegistrationNo4).HasColumnName("Company Registration No. (4)");
            entity.Property(e => e.CountryIncorporated1).HasColumnName("Country Incorporated (1)");
            entity.Property(e => e.CountryIncorporated2).HasColumnName("Country Incorporated (2)");
            entity.Property(e => e.CountryIncorporated3).HasColumnName("Country Incorporated (3)");
            entity.Property(e => e.CountryIncorporated4).HasColumnName("Country Incorporated (4)");
            entity.Property(e => e.DateProprietorAdded).HasColumnName("Date Proprietor Added");
            entity.Property(e => e.MultipleAddressIndicator).HasColumnName("Multiple Address Indicator");
            entity.Property(e => e.PricePaid).HasColumnName("Price Paid");
            entity.Property(e => e.PropertyAddress).HasColumnName("Property Address");
            entity.Property(e => e.Proprietor1Address1).HasColumnName("Proprietor (1) Address (1)");
            entity.Property(e => e.Proprietor1Address2).HasColumnName("Proprietor (1) Address (2)");
            entity.Property(e => e.Proprietor1Address3).HasColumnName("Proprietor (1) Address (3)");
            entity.Property(e => e.Proprietor2Address1).HasColumnName("Proprietor (2) Address (1)");
            entity.Property(e => e.Proprietor2Address2).HasColumnName("Proprietor (2) Address (2)");
            entity.Property(e => e.Proprietor2Address3).HasColumnName("Proprietor (2) Address (3)");
            entity.Property(e => e.Proprietor3Address1).HasColumnName("Proprietor (3) Address (1)");
            entity.Property(e => e.Proprietor3Address2).HasColumnName("Proprietor (3) Address (2)");
            entity.Property(e => e.Proprietor3Address3).HasColumnName("Proprietor (3) Address (3)");
            entity.Property(e => e.Proprietor4Address1).HasColumnName("Proprietor (4) Address (1)");
            entity.Property(e => e.Proprietor4Address2).HasColumnName("Proprietor (4) Address (2)");
            entity.Property(e => e.Proprietor4Address3).HasColumnName("Proprietor (4) Address (3)");
            entity.Property(e => e.ProprietorName1).HasColumnName("Proprietor Name (1)");
            entity.Property(e => e.ProprietorName2).HasColumnName("Proprietor Name (2)");
            entity.Property(e => e.ProprietorName3).HasColumnName("Proprietor Name (3)");
            entity.Property(e => e.ProprietorName4).HasColumnName("Proprietor Name (4)");
            entity.Property(e => e.ProprietorshipCategory1).HasColumnName("Proprietorship Category (1)");
            entity.Property(e => e.ProprietorshipCategory2).HasColumnName("Proprietorship Category (2)");
            entity.Property(e => e.ProprietorshipCategory3).HasColumnName("Proprietorship Category (3)");
            entity.Property(e => e.ProprietorshipCategory4).HasColumnName("Proprietorship Category (4)");
            entity.Property(e => e.TitleNumber).HasColumnName("Title Number");
        });

        modelBuilder.Entity<HmlrPolyTitleToUprn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("hmlr-poly-title-to-uprn");

            entity.Property(e => e.TitleNumber).HasColumnName("Title Number");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
        });

        modelBuilder.Entity<OsRecordtype21>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_21");

            entity.Property(e => e.AddressbasePostal).HasColumnName("ADDRESSBASE_POSTAL");
            entity.Property(e => e.BlpuState).HasColumnName("BLPU_STATE");
            entity.Property(e => e.BlpuStateDate).HasColumnName("BLPU_STATE_DATE");
            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.Country).HasColumnName("COUNTRY");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.Latitude).HasColumnName("LATITUDE");
            entity.Property(e => e.LocalCustodianCode).HasColumnName("LOCAL_CUSTODIAN_CODE");
            entity.Property(e => e.LogicalStatus).HasColumnName("LOGICAL_STATUS");
            entity.Property(e => e.Longitude).HasColumnName("LONGITUDE");
            entity.Property(e => e.MultiOccCount).HasColumnName("MULTI_OCC_COUNT");
            entity.Property(e => e.ParentUprn).HasColumnName("PARENT_UPRN");
            entity.Property(e => e.PostcodeLocator).HasColumnName("POSTCODE_LOCATOR");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.Rpc).HasColumnName("RPC");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
            entity.Property(e => e.XCoordinate).HasColumnName("X_COORDINATE");
            entity.Property(e => e.YCoordinate).HasColumnName("Y_COORDINATE");
        });

        modelBuilder.Entity<OsRecordtype23>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_23");

            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.CrossReference).HasColumnName("CROSS_REFERENCE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.Source).HasColumnName("SOURCE");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
            entity.Property(e => e.Version).HasColumnName("VERSION");
            entity.Property(e => e.XrefKey).HasColumnName("XREF_KEY");
        });

        modelBuilder.Entity<OsRecordtype24>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_24");

            entity.Property(e => e.AreaName).HasColumnName("AREA_NAME");
            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.Language).HasColumnName("LANGUAGE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.Level).HasColumnName("LEVEL");
            entity.Property(e => e.LogicalStatus).HasColumnName("LOGICAL_STATUS");
            entity.Property(e => e.LpiKey).HasColumnName("LPI_KEY");
            entity.Property(e => e.OfficialFlag).HasColumnName("OFFICIAL_FLAG");
            entity.Property(e => e.PaoEndNumber).HasColumnName("PAO_END_NUMBER");
            entity.Property(e => e.PaoEndSuffix).HasColumnName("PAO_END_SUFFIX");
            entity.Property(e => e.PaoStartNumber).HasColumnName("PAO_START_NUMBER");
            entity.Property(e => e.PaoStartSuffix).HasColumnName("PAO_START_SUFFIX");
            entity.Property(e => e.PaoText).HasColumnName("PAO_TEXT");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.SaoEndNumber).HasColumnName("SAO_END_NUMBER");
            entity.Property(e => e.SaoEndSuffix).HasColumnName("SAO_END_SUFFIX");
            entity.Property(e => e.SaoStartNumber).HasColumnName("SAO_START_NUMBER");
            entity.Property(e => e.SaoStartSuffix).HasColumnName("SAO_START_SUFFIX");
            entity.Property(e => e.SaoText).HasColumnName("SAO_TEXT");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
            entity.Property(e => e.Usrn).HasColumnName("USRN");
            entity.Property(e => e.UsrnMatchIndicator).HasColumnName("USRN_MATCH_INDICATOR");
        });

        modelBuilder.Entity<OsRecordtype28>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_28");

            entity.Property(e => e.BuildingName).HasColumnName("BUILDING_NAME");
            entity.Property(e => e.BuildingNumber).HasColumnName("BUILDING_NUMBER");
            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.DeliveryPointSuffix).HasColumnName("DELIVERY_POINT_SUFFIX");
            entity.Property(e => e.DepartmentName).HasColumnName("DEPARTMENT_NAME");
            entity.Property(e => e.DependentLocality).HasColumnName("DEPENDENT_LOCALITY");
            entity.Property(e => e.DependentThoroughfare).HasColumnName("DEPENDENT_THOROUGHFARE");
            entity.Property(e => e.DoubleDependentLocality).HasColumnName("DOUBLE_DEPENDENT_LOCALITY");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.OrganisationName).HasColumnName("ORGANISATION_NAME");
            entity.Property(e => e.PoBoxNumber).HasColumnName("PO_BOX_NUMBER");
            entity.Property(e => e.PostTown).HasColumnName("POST_TOWN");
            entity.Property(e => e.Postcode).HasColumnName("POSTCODE");
            entity.Property(e => e.PostcodeType).HasColumnName("POSTCODE_TYPE");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.ProcessDate).HasColumnName("PROCESS_DATE");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.SubBuildingName).HasColumnName("SUB_BUILDING_NAME");
            entity.Property(e => e.Thoroughfare).HasColumnName("THOROUGHFARE");
            entity.Property(e => e.Udprn).HasColumnName("UDPRN");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
            entity.Property(e => e.WelshDependentLocality).HasColumnName("WELSH_DEPENDENT_LOCALITY");
            entity.Property(e => e.WelshDependentThoroughfare).HasColumnName("WELSH_DEPENDENT_THOROUGHFARE");
            entity.Property(e => e.WelshDoubleDependentLocality).HasColumnName("WELSH_DOUBLE_DEPENDENT_LOCALITY");
            entity.Property(e => e.WelshPostTown).HasColumnName("WELSH_POST_TOWN");
            entity.Property(e => e.WelshThoroughfare).HasColumnName("WELSH_THOROUGHFARE");
        });

        modelBuilder.Entity<OsRecordtype31>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_31");

            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.LegalName).HasColumnName("LEGAL_NAME");
            entity.Property(e => e.OrgKey).HasColumnName("ORG_KEY");
            entity.Property(e => e.Organisation).HasColumnName("ORGANISATION");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
        });

        modelBuilder.Entity<OsRecordtype32>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("os_recordtype_32");

            entity.Property(e => e.ChangeType).HasColumnName("CHANGE_TYPE");
            entity.Property(e => e.ClassKey).HasColumnName("CLASS_KEY");
            entity.Property(e => e.ClassScheme).HasColumnName("CLASS_SCHEME");
            entity.Property(e => e.ClassificationCode).HasColumnName("CLASSIFICATION_CODE");
            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.EntryDate).HasColumnName("ENTRY_DATE");
            entity.Property(e => e.LastUpdateDate).HasColumnName("LAST_UPDATE_DATE");
            entity.Property(e => e.ProOrder).HasColumnName("PRO_ORDER");
            entity.Property(e => e.RecordIdentifier).HasColumnName("RECORD_IDENTIFIER");
            entity.Property(e => e.SchemeVersion).HasColumnName("SCHEME_VERSION");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
            entity.Property(e => e.Uprn).HasColumnName("UPRN");
        });

        modelBuilder.Entity<VoaBusinessRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("voa-business-rates");

            entity.Property(e => e.AppealStmtCode).HasColumnName("appeal_stmt_code");
            entity.Property(e => e.AssessmentRef).HasColumnName("assessment_ref");
            entity.Property(e => e.BaRefNumber).HasColumnName("ba_ref_number");
            entity.Property(e => e.BillAuthCode).HasColumnName("bill_auth_code");
            entity.Property(e => e.CaseNumber).HasColumnName("case_number");
            entity.Property(e => e.CompositeIndicator).HasColumnName("composite_indicator");
            entity.Property(e => e.County).HasColumnName("county");
            entity.Property(e => e.CurrentFromDate).HasColumnName("current_from_date");
            entity.Property(e => e.CurrentToDate).HasColumnName("current_to_date");
            entity.Property(e => e.EffectiveDate).HasColumnName("effective_date");
            entity.Property(e => e.EntryNumber).HasColumnName("entry_number");
            entity.Property(e => e.FirmName).HasColumnName("firm_name");
            entity.Property(e => e.FullPropertyIdentifier).HasColumnName("full_property_identifier");
            entity.Property(e => e.ListAlterationDate).HasColumnName("list_alteration_date");
            entity.Property(e => e.NdrCommunityCode).HasColumnName("ndr_community_code");
            entity.Property(e => e.NumberOrName).HasColumnName("number_or_name");
            entity.Property(e => e.PostalDistrict).HasColumnName("postal_district");
            entity.Property(e => e.Postcode).HasColumnName("postcode");
            entity.Property(e => e.PriDesc).HasColumnName("pri_desc");
            entity.Property(e => e.PriSecDescCode).HasColumnName("pri_sec_desc_code");
            entity.Property(e => e.RateableValue).HasColumnName("rateable_value");
            entity.Property(e => e.ScatCodeAndSuffix).HasColumnName("scat_code_and_suffix");
            entity.Property(e => e.Street).HasColumnName("street");
            entity.Property(e => e.SubStreetLvl1).HasColumnName("sub_street_lvl1");
            entity.Property(e => e.SubStreetLvl2).HasColumnName("sub_street_lvl2");
            entity.Property(e => e.SubStreetLvl3).HasColumnName("sub_street_lvl3");
            entity.Property(e => e.Town).HasColumnName("town");
            entity.Property(e => e.Uarn).HasColumnName("uarn");
            entity.Property(e => e._29).HasColumnName("29");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
