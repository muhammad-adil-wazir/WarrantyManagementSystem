﻿// <auto-generated />
using GwDealerPortal.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GwDealerPortal.DataAccess.Migrations
{
    [DbContext(typeof(WMSDBContext))]
    [Migration("20190221065007_WMSDBConnctin35")]
    partial class WMSDBConnctin35
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.BWDealerPolicy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Brand");

                    b.Property<string>("ClientRefNumber");

                    b.Property<string>("ContactNumber");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("CustomerName");

                    b.Property<string>("DealerName");

                    b.Property<int>("ExtendedWarrantyDuration");

                    b.Property<DateTime>("ExtendedWarrantyEndDate");

                    b.Property<DateTime>("ExtendedWarrantyStartDate");

                    b.Property<string>("ExtendedWarrantyType");

                    b.Property<decimal>("GrossPremium");

                    b.Property<decimal>("GrossPremiumPercentage");

                    b.Property<DateTime>("InvoiceDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ManufacturerWarrantyDuration");

                    b.Property<DateTime>("ManufacturerWarrantyEndDate");

                    b.Property<DateTime>("ManufacturerWarrantyStartDate");

                    b.Property<string>("Model");

                    b.Property<int>("ModelYear");

                    b.Property<string>("PolicyNumber");

                    b.Property<string>("ProductCategory");

                    b.Property<decimal>("ProductPrice");

                    b.Property<string>("ProductType");

                    b.Property<string>("Remarks");

                    b.Property<string>("SalesMan");

                    b.Property<string>("UIN");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ID");

                    b.ToTable("BWDealerPolicy");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.CCRange", b =>
                {
                    b.Property<int>("CCRangeID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CCRangeName");

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("CCRangeID");

                    b.ToTable("CCRange");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ClaimLimit", b =>
                {
                    b.Property<int>("ClaimLimitID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimLimitName");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("DealerID");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ProductSubGroupID");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ClaimLimitID");

                    b.ToTable("ClaimLimit");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ClaimsStatus", b =>
                {
                    b.Property<int>("SlNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClaimCode");

                    b.Property<int>("ClaimStatus");

                    b.HasKey("SlNumber");

                    b.HasIndex("ClaimCode");

                    b.ToTable("ClaimsStatus");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Dealer", b =>
                {
                    b.Property<int>("DealerCode")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccGroupCode");

                    b.Property<string>("AccountContactNo");

                    b.Property<string>("AccountContactPerson");

                    b.Property<string>("AccountFaxNo");

                    b.Property<string>("AccountPhoneNo");

                    b.Property<string>("Address");

                    b.Property<float>("BWPremiumPerc");

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("DeactivationDate");

                    b.Property<string>("DealerName");

                    b.Property<string>("DeductableValue");

                    b.Property<string>("Email");

                    b.Property<string>("IUD");

                    b.Property<string>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("IsSelfAuthorityLimit");

                    b.Property<int>("LedgerCode");

                    b.Property<int>("NoOfInstalments");

                    b.Property<int>("OldDealerCode");

                    b.Property<int>("OldLedgerCode");

                    b.Property<int>("PrivateSale");

                    b.Property<string>("Remarks");

                    b.Property<string>("SaleFaxNo");

                    b.Property<string>("SalesPhoneNo");

                    b.Property<string>("SelfAuthorityLimit");

                    b.Property<string>("ServiceContactPerson");

                    b.Property<int>("SubGroupCode");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("DealerCode");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.DealerBranch", b =>
                {
                    b.Property<int>("DealerBranchID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DealerBranchName");

                    b.Property<int>("DealerID");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("DealerBranchID");

                    b.HasIndex("DealerID");

                    b.ToTable("DealerBranch");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Duration", b =>
                {
                    b.Property<int>("DurationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("DurationName");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ProductSubGroupID");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("DurationID");

                    b.ToTable("Duration");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.EntryEligibility", b =>
                {
                    b.Property<int>("EntryEligibilityID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeLimit");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EntryMillage");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ProductSubGroupID");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("EntryEligibilityID");

                    b.ToTable("EntryEligibility");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.EventAccess", b =>
                {
                    b.Property<int>("EventAccessID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EventAccessName");

                    b.HasKey("EventAccessID");

                    b.ToTable("EventAccess");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Filter", b =>
                {
                    b.Property<int>("FilterID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("EventAccessID");

                    b.Property<int>("FilterTypeID");

                    b.Property<int>("FilterTypeValue");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int?>("UserID");

                    b.Property<int>("UserRoleID");

                    b.HasKey("FilterID");

                    b.ToTable("Filter");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.FilterType", b =>
                {
                    b.Property<int>("FilterTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FilterTypeName");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("FilterTypeID");

                    b.ToTable("FilterType");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Interface", b =>
                {
                    b.Property<int>("InterfaceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("InterfaceName");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ParentInterfaceID");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("InterfaceID");

                    b.ToTable("Interface");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Location", b =>
                {
                    b.Property<int>("LocationCode")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LocationName");

                    b.Property<string>("Remarks");

                    b.Property<int>("SINum");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int>("WEMSLocationCode");

                    b.HasKey("LocationCode");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ModelYear", b =>
                {
                    b.Property<int>("ModelYearID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModelYearName");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ModelYearID");

                    b.ToTable("ModelYear");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.OtherService", b =>
                {
                    b.Property<int>("OtherServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("Amount");

                    b.Property<int>("BranchID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("OtherServiceName");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("OtherServiceID");

                    b.ToTable("OtherService");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Policy", b =>
                {
                    b.Property<int>("SINum")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<DateTime?>("ApprovalDate");

                    b.Property<int>("BranchID");

                    b.Property<string>("BranchName");

                    b.Property<int?>("CC");

                    b.Property<int>("CCRangeId");

                    b.Property<string>("Capacity");

                    b.Property<string>("CapacityRange");

                    b.Property<string>("Category");

                    b.Property<int>("CategoryId");

                    b.Property<string>("City");

                    b.Property<string>("ClaimLimit");

                    b.Property<string>("ClientRefNum");

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<float?>("CurrentMileage");

                    b.Property<string>("CustomerName");

                    b.Property<int>("DealerID");

                    b.Property<string>("DealerName");

                    b.Property<string>("Description");

                    b.Property<float>("Discount");

                    b.Property<string>("DocNumber");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("ExpiryDate");

                    b.Property<string>("ExtCutoff");

                    b.Property<int>("ExtDurationID");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("IssueDate");

                    b.Property<int>("LocationCode");

                    b.Property<int>("MakeId");

                    b.Property<string>("ManuCutoff");

                    b.Property<int>("ManuDuration");

                    b.Property<DateTime?>("ManuExpiryDate");

                    b.Property<string>("MobileNum");

                    b.Property<int>("ModelId");

                    b.Property<int>("ModelYearId");

                    b.Property<string>("PlateType");

                    b.Property<int>("PolNumber");

                    b.Property<float>("Premium");

                    b.Property<float>("PremiumPercentage");

                    b.Property<string>("ProductGroup");

                    b.Property<int>("ProductGroupId");

                    b.Property<float>("ProductPrice");

                    b.Property<int>("ProductSubGroupId");

                    b.Property<string>("ProductSubGroupName");

                    b.Property<int>("ProgramID");

                    b.Property<string>("RefNumber");

                    b.Property<DateTime?>("RegDate");

                    b.Property<string>("RegNumber");

                    b.Property<string>("Remarks");

                    b.Property<string>("Size");

                    b.Property<string>("SizeRange");

                    b.Property<string>("SoldBy");

                    b.Property<DateTime?>("SoldDate");

                    b.Property<DateTime?>("StartDate");

                    b.Property<int>("Status");

                    b.Property<string>("SubCategory");

                    b.Property<int>("SubCategoryId");

                    b.Property<string>("UINumber");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<int>("WarrantyType");

                    b.HasKey("SINum");

                    b.ToTable("Policy");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.PolicyService", b =>
                {
                    b.Property<int>("PolicyServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("OtherServiceID");

                    b.Property<int>("PolicyID");

                    b.HasKey("PolicyServiceID");

                    b.ToTable("PolicyService");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.PolicyStatus", b =>
                {
                    b.Property<int>("StatusID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EmailText");

                    b.Property<string>("StatusName");

                    b.HasKey("StatusID");

                    b.ToTable("PolicyStatus");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Premium", b =>
                {
                    b.Property<int>("SINum")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<int>("ConfigID");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("DealerID");

                    b.Property<int>("Duration");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LocationCode");

                    b.Property<int>("PremiumID");

                    b.Property<float>("PremiumPercentage");

                    b.Property<int>("ProductSubGroupID");

                    b.Property<int>("ProgramID");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<DateTime>("ValidFrom");

                    b.Property<float>("ValidTo");

                    b.Property<int>("WarrantyTypeID");

                    b.HasKey("SINum");

                    b.ToTable("Premium");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ProcessClaim", b =>
                {
                    b.Property<int>("ClaimCode")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("ActualClaimAmount");

                    b.Property<string>("ActualInvoiceAmt");

                    b.Property<decimal?>("ArigPaidAmountUSD");

                    b.Property<string>("ArigRejection");

                    b.Property<string>("ArigRejectionCode");

                    b.Property<DateTime?>("AuthorisedOn");

                    b.Property<decimal?>("AuthorizedAmount");

                    b.Property<int?>("AuthorizedBy");

                    b.Property<int?>("BranchCode");

                    b.Property<DateTime?>("ClaimDate");

                    b.Property<int?>("ClaimFrom");

                    b.Property<string>("ClaimNo");

                    b.Property<int?>("ConfigID");

                    b.Property<string>("ContactPerson");

                    b.Property<string>("ContactPhone");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int?>("CurrencyCode");

                    b.Property<DateTime?>("CustomerInvoiceDate");

                    b.Property<string>("CustomerInvoiceNo");

                    b.Property<DateTime?>("CustomerInvoiceReceivedOn");

                    b.Property<DateTime?>("DateOfFailure");

                    b.Property<decimal?>("DeductableAmount");

                    b.Property<DateTime?>("EnteredOn");

                    b.Property<float?>("ExchangeRate");

                    b.Property<int?>("FYCode");

                    b.Property<DateTime?>("FaxReceivedDate");

                    b.Property<string>("FaxReceivedTime");

                    b.Property<string>("GwAuthNo");

                    b.Property<string>("IUD");

                    b.Property<string>("InspectionNo");

                    b.Property<string>("Inspector");

                    b.Property<string>("InspectorComments");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("IsFirstAboveCover");

                    b.Property<string>("IsInspectionDone");

                    b.Property<bool>("IsMfgAssistance");

                    b.Property<string>("IsSPR");

                    b.Property<string>("JobCardNo");

                    b.Property<string>("LaborCostAftDisc");

                    b.Property<string>("LabourCharges");

                    b.Property<float?>("LabourDiscountPer");

                    b.Property<int?>("LastBreakdownMileage");

                    b.Property<string>("LastClaimDetails");

                    b.Property<DateTime?>("LastServiceDate");

                    b.Property<string>("LastServiceDetails");

                    b.Property<int?>("LastServiceMileage");

                    b.Property<string>("Legal");

                    b.Property<string>("MajorFaultCode");

                    b.Property<int?>("OldClaimCode");

                    b.Property<float?>("OtherDiscountPer");

                    b.Property<string>("OverLimitReasonDesc");

                    b.Property<int?>("ParameterCode");

                    b.Property<string>("ParameterValue");

                    b.Property<string>("PartsCostAftDisc");

                    b.Property<int?>("PayeeID");

                    b.Property<string>("PolicyCode");

                    b.Property<string>("ReasonForRejectionHold");

                    b.Property<int?>("ReasonInspNotDone");

                    b.Property<string>("Remarks");

                    b.Property<string>("RepairerComments");

                    b.Property<int?>("RepairerID");

                    b.Property<decimal?>("RequestedAmount");

                    b.Property<string>("SPDetails");

                    b.Property<string>("ServiceCharges");

                    b.Property<float?>("ServiceDiscountPer");

                    b.Property<int?>("Status");

                    b.Property<float?>("TaxPer");

                    b.Property<string>("TaxValue");

                    b.Property<decimal?>("TotalAmount");

                    b.Property<decimal?>("TotalClaimAmount");

                    b.Property<string>("TotalLabourCost");

                    b.Property<float?>("TotalOtherDiscount");

                    b.Property<string>("TotalPartsCost");

                    b.Property<string>("TotalServiceCost");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ClaimCode");

                    b.ToTable("ProcessClaim");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ProcessClaimDetail", b =>
                {
                    b.Property<int>("ProcessClaimDetailID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ActualCost");

                    b.Property<int>("ClaimCode");

                    b.Property<string>("Comments");

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("FaultCode");

                    b.Property<string>("FinalCost");

                    b.Property<string>("Inspection");

                    b.Property<string>("InspectionNo");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("IsInspectionDone");

                    b.Property<string>("IsService");

                    b.Property<string>("LaborCost");

                    b.Property<float>("LaborDisPer");

                    b.Property<float>("MfgDisPer");

                    b.Property<string>("OtherCost");

                    b.Property<int>("PartCategory");

                    b.Property<int>("PartCode");

                    b.Property<int>("PartSRNumber");

                    b.Property<string>("Remarks");

                    b.Property<float>("RepairerDisPer");

                    b.Property<string>("ServiceDisPerc");

                    b.Property<string>("Total");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("ProcessClaimDetailID");

                    b.HasIndex("ClaimCode");

                    b.ToTable("ProcessClaimDetail");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.Program", b =>
                {
                    b.Property<int>("SINum")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("ProgramID");

                    b.Property<string>("ProgramName");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("SINum");

                    b.ToTable("Program");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("ClaimApprovalLimit");

                    b.Property<int>("DealerID");

                    b.Property<string>("Email");

                    b.Property<string>("IUD");

                    b.Property<int>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDateTime");

                    b.Property<int?>("OldUserID");

                    b.Property<int?>("PasswordExpiryInDays");

                    b.Property<string>("PersonName");

                    b.Property<int>("RoleCode");

                    b.Property<int>("UserCode");

                    b.Property<string>("UserName");

                    b.Property<string>("UserPassword");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.UserRole", b =>
                {
                    b.Property<int>("UserRoleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("UserRoleName");

                    b.HasKey("UserRoleID");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.WarrantyType", b =>
                {
                    b.Property<int>("WarrantyTypeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CreatedById");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Remarks");

                    b.Property<int>("SINum");

                    b.Property<int?>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.Property<string>("WarrantyTypeName");

                    b.HasKey("WarrantyTypeID");

                    b.ToTable("WarrantyType");
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ClaimsStatus", b =>
                {
                    b.HasOne("GwDealerPortal.DataAccess.Entities.ProcessClaim", "ProcessClaim")
                        .WithMany()
                        .HasForeignKey("ClaimCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.DealerBranch", b =>
                {
                    b.HasOne("GwDealerPortal.DataAccess.Entities.Dealer", "Dealer")
                        .WithMany()
                        .HasForeignKey("DealerID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GwDealerPortal.DataAccess.Entities.ProcessClaimDetail", b =>
                {
                    b.HasOne("GwDealerPortal.DataAccess.Entities.ProcessClaim", "ProcessClaim")
                        .WithMany("ProcessClaimDetail")
                        .HasForeignKey("ClaimCode")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
