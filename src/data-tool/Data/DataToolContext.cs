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

    public virtual DbSet<AbpBlpu> AbpBlpus { get; set; }

    public virtual DbSet<AbpClassification> AbpClassifications { get; set; }

    public virtual DbSet<AbpCrossref> AbpCrossrefs { get; set; }

    public virtual DbSet<AbpDeliveryPoint> AbpDeliveryPoints { get; set; }

    public virtual DbSet<AbpLpi> AbpLpis { get; set; }

    public virtual DbSet<AbpOrganisation> AbpOrganisations { get; set; }

    public virtual DbSet<AbpStreet> AbpStreets { get; set; }

    public virtual DbSet<AbpStreetDescriptor> AbpStreetDescriptors { get; set; }

    public virtual DbSet<AbpSuccessor> AbpSuccessors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Name=DbConnectionString");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbpBlpu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_blpu");

            entity.Property(e => e.AddressbasePostal)
                .HasMaxLength(1)
                .HasColumnName("addressbase_postal");
            entity.Property(e => e.BlpuState).HasColumnName("blpu_state");
            entity.Property(e => e.BlpuStateDate).HasColumnName("blpu_state_date");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.Country)
                .HasMaxLength(1)
                .HasColumnName("country");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.LocalCustodianCode).HasColumnName("local_custodian_code");
            entity.Property(e => e.LogicalStatus).HasColumnName("logical_status");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.MultiOccCount).HasColumnName("multi_occ_count");
            entity.Property(e => e.ParentUprn).HasColumnName("parent_uprn");
            entity.Property(e => e.PostcodeLocator)
                .HasMaxLength(8)
                .HasColumnName("postcode_locator");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.Rpc).HasColumnName("rpc");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
            entity.Property(e => e.XCoordinate).HasColumnName("x_coordinate");
            entity.Property(e => e.YCoordinate).HasColumnName("y_coordinate");
        });

        modelBuilder.Entity<AbpClassification>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_classification");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.ClassKey)
                .HasMaxLength(14)
                .HasColumnName("class_key");
            entity.Property(e => e.ClassScheme)
                .HasMaxLength(60)
                .HasColumnName("class_scheme");
            entity.Property(e => e.ClassificationCode)
                .HasMaxLength(6)
                .HasColumnName("classification_code");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.SchemeVersion).HasColumnName("scheme_version");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
        });

        modelBuilder.Entity<AbpCrossref>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_crossref");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.CrossReference)
                .HasMaxLength(50)
                .HasColumnName("cross_reference");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.Source)
                .HasMaxLength(6)
                .HasColumnName("source");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
            entity.Property(e => e.Version).HasColumnName("version");
            entity.Property(e => e.XrefKey)
                .HasMaxLength(14)
                .HasColumnName("xref_key");
        });

        modelBuilder.Entity<AbpDeliveryPoint>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_delivery_point");

            entity.Property(e => e.BuildingName)
                .HasMaxLength(80)
                .HasColumnName("building_name");
            entity.Property(e => e.BuildingNumber).HasColumnName("building_number");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.DeliveryPointSuffix)
                .HasMaxLength(2)
                .HasColumnName("delivery_point_suffix");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(60)
                .HasColumnName("department_name");
            entity.Property(e => e.DependentLocality)
                .HasMaxLength(35)
                .HasColumnName("dependent_locality");
            entity.Property(e => e.DependentThoroughfare)
                .HasMaxLength(80)
                .HasColumnName("dependent_thoroughfare");
            entity.Property(e => e.DoubleDependentLocality)
                .HasMaxLength(35)
                .HasColumnName("double_dependent_locality");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(60)
                .HasColumnName("organisation_name");
            entity.Property(e => e.PoBoxNumber)
                .HasMaxLength(6)
                .HasColumnName("po_box_number");
            entity.Property(e => e.PostTown)
                .HasMaxLength(30)
                .HasColumnName("post_town");
            entity.Property(e => e.Postcode)
                .HasMaxLength(8)
                .HasColumnName("postcode");
            entity.Property(e => e.PostcodeType)
                .HasMaxLength(1)
                .HasColumnName("postcode_type");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.ProcessDate).HasColumnName("process_date");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.SubBuildingName)
                .HasMaxLength(30)
                .HasColumnName("sub_building_name");
            entity.Property(e => e.Thoroughfare)
                .HasMaxLength(80)
                .HasColumnName("thoroughfare");
            entity.Property(e => e.Udprn).HasColumnName("udprn");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
            entity.Property(e => e.WelshDependentLocality)
                .HasMaxLength(35)
                .HasColumnName("welsh_dependent_locality");
            entity.Property(e => e.WelshDependentThoroughfare)
                .HasMaxLength(80)
                .HasColumnName("welsh_dependent_thoroughfare");
            entity.Property(e => e.WelshDoubleDependentLocality)
                .HasMaxLength(35)
                .HasColumnName("welsh_double_dependent_locality");
            entity.Property(e => e.WelshPostTown)
                .HasMaxLength(30)
                .HasColumnName("welsh_post_town");
            entity.Property(e => e.WelshThoroughfare)
                .HasMaxLength(80)
                .HasColumnName("welsh_thoroughfare");
        });

        modelBuilder.Entity<AbpLpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_lpi");

            entity.Property(e => e.AreaName)
                .HasMaxLength(35)
                .HasColumnName("area_name");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("language");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Level)
                .HasMaxLength(30)
                .HasColumnName("level");
            entity.Property(e => e.LogicalStatus).HasColumnName("logical_status");
            entity.Property(e => e.LpiKey)
                .HasMaxLength(14)
                .HasColumnName("lpi_key");
            entity.Property(e => e.OfficialFlag)
                .HasMaxLength(1)
                .HasColumnName("official_flag");
            entity.Property(e => e.PaoEndNumber).HasColumnName("pao_end_number");
            entity.Property(e => e.PaoEndSuffix)
                .HasMaxLength(2)
                .HasColumnName("pao_end_suffix");
            entity.Property(e => e.PaoStartNumber).HasColumnName("pao_start_number");
            entity.Property(e => e.PaoStartSuffix)
                .HasMaxLength(2)
                .HasColumnName("pao_start_suffix");
            entity.Property(e => e.PaoText)
                .HasMaxLength(90)
                .HasColumnName("pao_text");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.SaoEndNumber).HasColumnName("sao_end_number");
            entity.Property(e => e.SaoEndSuffix)
                .HasMaxLength(2)
                .HasColumnName("sao_end_suffix");
            entity.Property(e => e.SaoStartNumber).HasColumnName("sao_start_number");
            entity.Property(e => e.SaoStartSuffix)
                .HasMaxLength(2)
                .HasColumnName("sao_start_suffix");
            entity.Property(e => e.SaoText)
                .HasMaxLength(90)
                .HasColumnName("sao_text");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
            entity.Property(e => e.Usrn).HasColumnName("usrn");
            entity.Property(e => e.UsrnMatchIndicator)
                .HasMaxLength(1)
                .HasColumnName("usrn_match_indicator");
        });

        modelBuilder.Entity<AbpOrganisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_organisation");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.LegalName)
                .HasMaxLength(60)
                .HasColumnName("legal_name");
            entity.Property(e => e.OrgKey)
                .HasMaxLength(14)
                .HasColumnName("org_key");
            entity.Property(e => e.Organisation)
                .HasMaxLength(100)
                .HasColumnName("organisation");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
        });

        modelBuilder.Entity<AbpStreet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_street");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordEntryDate).HasColumnName("record_entry_date");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.RecordType).HasColumnName("record_type");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.StateDate).HasColumnName("state_date");
            entity.Property(e => e.StreetClassification).HasColumnName("street_classification");
            entity.Property(e => e.StreetEndDate).HasColumnName("street_end_date");
            entity.Property(e => e.StreetEndX).HasColumnName("street_end_x");
            entity.Property(e => e.StreetEndY).HasColumnName("street_end_y");
            entity.Property(e => e.StreetStartDate).HasColumnName("street_start_date");
            entity.Property(e => e.StreetStartX).HasColumnName("street_start_x");
            entity.Property(e => e.StreetStartY).HasColumnName("street_start_y");
            entity.Property(e => e.StreetSurface).HasColumnName("street_surface");
            entity.Property(e => e.StreetTolerance).HasColumnName("street_tolerance");
            entity.Property(e => e.SwaOrgRefNaming).HasColumnName("swa_org_ref_naming");
            entity.Property(e => e.Usrn).HasColumnName("usrn");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<AbpStreetDescriptor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_street_descriptor");

            entity.Property(e => e.AdministrativeArea)
                .HasMaxLength(30)
                .HasColumnName("administrative_area");
            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.Language)
                .HasMaxLength(3)
                .HasColumnName("language");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.Locality)
                .HasMaxLength(35)
                .HasColumnName("locality");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.StreetDescription)
                .HasMaxLength(110)
                .HasColumnName("street_description");
            entity.Property(e => e.TownName)
                .HasMaxLength(30)
                .HasColumnName("town_name");
            entity.Property(e => e.Usrn).HasColumnName("usrn");
        });

        modelBuilder.Entity<AbpSuccessor>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("abp_successor");

            entity.Property(e => e.ChangeType)
                .HasMaxLength(1)
                .HasColumnName("change_type");
            entity.Property(e => e.EndDate).HasColumnName("end_date");
            entity.Property(e => e.EntryDate).HasColumnName("entry_date");
            entity.Property(e => e.LastUpdateDate).HasColumnName("last_update_date");
            entity.Property(e => e.ProOrder).HasColumnName("pro_order");
            entity.Property(e => e.RecordIdentifier).HasColumnName("record_identifier");
            entity.Property(e => e.StartDate).HasColumnName("start_date");
            entity.Property(e => e.SuccKey)
                .HasMaxLength(14)
                .HasColumnName("succ_key");
            entity.Property(e => e.Successor).HasColumnName("successor");
            entity.Property(e => e.Uprn).HasColumnName("uprn");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
