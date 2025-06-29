using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EasyITCenter.DBModel
{
    public partial class ScaffoldContext : DbContext
    {
        public ScaffoldContext()
        {
        }

        public ScaffoldContext(DbContextOptions<ScaffoldContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BasicAttachmentList> BasicAttachmentLists { get; set; } = null!;
        public virtual DbSet<BasicCalendarList> BasicCalendarLists { get; set; } = null!;
        public virtual DbSet<BasicCurrencyList> BasicCurrencyLists { get; set; } = null!;
        public virtual DbSet<BasicImageGalleryList> BasicImageGalleryLists { get; set; } = null!;
        public virtual DbSet<BasicItemList> BasicItemLists { get; set; } = null!;
        public virtual DbSet<BasicUnitList> BasicUnitLists { get; set; } = null!;
        public virtual DbSet<BasicVatList> BasicVatLists { get; set; } = null!;
        public virtual DbSet<BasicViewAttachmentList> BasicViewAttachmentLists { get; set; } = null!;
        public virtual DbSet<BusinessAddressList> BusinessAddressLists { get; set; } = null!;
        public virtual DbSet<BusinessBranchList> BusinessBranchLists { get; set; } = null!;
        public virtual DbSet<BusinessCreditNoteList> BusinessCreditNoteLists { get; set; } = null!;
        public virtual DbSet<BusinessCreditNoteSupportList> BusinessCreditNoteSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessExchangeRateList> BusinessExchangeRateLists { get; set; } = null!;
        public virtual DbSet<BusinessIncomingInvoiceList> BusinessIncomingInvoiceLists { get; set; } = null!;
        public virtual DbSet<BusinessIncomingInvoiceSupportList> BusinessIncomingInvoiceSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessIncomingOrderList> BusinessIncomingOrderLists { get; set; } = null!;
        public virtual DbSet<BusinessIncomingOrderSupportList> BusinessIncomingOrderSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessMaturityList> BusinessMaturityLists { get; set; } = null!;
        public virtual DbSet<BusinessNotesList> BusinessNotesLists { get; set; } = null!;
        public virtual DbSet<BusinessOfferList> BusinessOfferLists { get; set; } = null!;
        public virtual DbSet<BusinessOfferSupportList> BusinessOfferSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessOutgoingInvoiceList> BusinessOutgoingInvoiceLists { get; set; } = null!;
        public virtual DbSet<BusinessOutgoingInvoiceSupportList> BusinessOutgoingInvoiceSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessOutgoingOrderList> BusinessOutgoingOrderLists { get; set; } = null!;
        public virtual DbSet<BusinessOutgoingOrderSupportList> BusinessOutgoingOrderSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessPaymentMethodList> BusinessPaymentMethodLists { get; set; } = null!;
        public virtual DbSet<BusinessPaymentStatusList> BusinessPaymentStatusLists { get; set; } = null!;
        public virtual DbSet<BusinessReceiptList> BusinessReceiptLists { get; set; } = null!;
        public virtual DbSet<BusinessReceiptSupportList> BusinessReceiptSupportLists { get; set; } = null!;
        public virtual DbSet<BusinessWarehouseList> BusinessWarehouseLists { get; set; } = null!;
        public virtual DbSet<DocSrvDocTemplateList> DocSrvDocTemplateLists { get; set; } = null!;
        public virtual DbSet<DocSrvDocumentationCodeLibraryList> DocSrvDocumentationCodeLibraryLists { get; set; } = null!;
        public virtual DbSet<DocSrvDocumentationGroupList> DocSrvDocumentationGroupLists { get; set; } = null!;
        public virtual DbSet<DocSrvDocumentationList> DocSrvDocumentationLists { get; set; } = null!;
        public virtual DbSet<GithubSrvAuthLogList> GithubSrvAuthLogLists { get; set; } = null!;
        public virtual DbSet<GithubSrvRepositoryList> GithubSrvRepositoryLists { get; set; } = null!;
        public virtual DbSet<GithubSrvSshKeyList> GithubSrvSshKeyLists { get; set; } = null!;
        public virtual DbSet<GithubSrvTeamList> GithubSrvTeamLists { get; set; } = null!;
        public virtual DbSet<GithubSrvTeamRepositoryRoleList> GithubSrvTeamRepositoryRoleLists { get; set; } = null!;
        public virtual DbSet<GithubSrvUserTeamRoleList> GithubSrvUserTeamRoleLists { get; set; } = null!;
        public virtual DbSet<LicSrvLicenseActivationFailList> LicSrvLicenseActivationFailLists { get; set; } = null!;
        public virtual DbSet<LicSrvLicenseAlgorithmList> LicSrvLicenseAlgorithmLists { get; set; } = null!;
        public virtual DbSet<LicSrvUsedLicenseList> LicSrvUsedLicenseLists { get; set; } = null!;
        public virtual DbSet<MigrationsHistoryList> MigrationsHistoryLists { get; set; } = null!;
        public virtual DbSet<PortalActionHistoryList> PortalActionHistoryLists { get; set; } = null!;
        public virtual DbSet<PortalActionTypeList> PortalActionTypeLists { get; set; } = null!;
        public virtual DbSet<PortalApiTableColumnDataList> PortalApiTableColumnDataLists { get; set; } = null!;
        public virtual DbSet<PortalApiTableColumnList> PortalApiTableColumnLists { get; set; } = null!;
        public virtual DbSet<PortalApiTableList> PortalApiTableLists { get; set; } = null!;
        public virtual DbSet<PortalApiTableTypeList> PortalApiTableTypeLists { get; set; } = null!;
        public virtual DbSet<PortalDataHistoryList> PortalDataHistoryLists { get; set; } = null!;
        public virtual DbSet<PortalDataTypeList> PortalDataTypeLists { get; set; } = null!;
        public virtual DbSet<PortalGeneratedDataList> PortalGeneratedDataLists { get; set; } = null!;
        public virtual DbSet<PortalGeneratorActionList> PortalGeneratorActionLists { get; set; } = null!;
        public virtual DbSet<PortalGeneratorList> PortalGeneratorLists { get; set; } = null!;
        public virtual DbSet<PortalGeneratorTemplateList> PortalGeneratorTemplateLists { get; set; } = null!;
        public virtual DbSet<PortalGeneratorTypeList> PortalGeneratorTypeLists { get; set; } = null!;
        public virtual DbSet<PortalHelpDataList> PortalHelpDataLists { get; set; } = null!;
        public virtual DbSet<PortalHelpGroupList> PortalHelpGroupLists { get; set; } = null!;
        public virtual DbSet<PortalInjectGroupList> PortalInjectGroupLists { get; set; } = null!;
        public virtual DbSet<PortalInjectPageCodeList> PortalInjectPageCodeLists { get; set; } = null!;
        public virtual DbSet<PortalPluginList> PortalPluginLists { get; set; } = null!;
        public virtual DbSet<PortalTemplateTypeList> PortalTemplateTypeLists { get; set; } = null!;
        public virtual DbSet<PortalUserCommentList> PortalUserCommentLists { get; set; } = null!;
        public virtual DbSet<PortalUserPageList> PortalUserPageLists { get; set; } = null!;
        public virtual DbSet<PortalUserPageMenuList> PortalUserPageMenuLists { get; set; } = null!;
        public virtual DbSet<ProdGuidGroupList> ProdGuidGroupLists { get; set; } = null!;
        public virtual DbSet<ProdGuidOperationList> ProdGuidOperationLists { get; set; } = null!;
        public virtual DbSet<ProdGuidPartList> ProdGuidPartLists { get; set; } = null!;
        public virtual DbSet<ProdGuidPersonList> ProdGuidPersonLists { get; set; } = null!;
        public virtual DbSet<ProdGuidWorkList> ProdGuidWorkLists { get; set; } = null!;
        public virtual DbSet<ServerApiSecurityList> ServerApiSecurityLists { get; set; } = null!;
        public virtual DbSet<ServerCorsDefAllowedOriginList> ServerCorsDefAllowedOriginLists { get; set; } = null!;
        public virtual DbSet<ServerHealthCheckTaskList> ServerHealthCheckTaskLists { get; set; } = null!;
        public virtual DbSet<ServerLiveDataMonitorList> ServerLiveDataMonitorLists { get; set; } = null!;
        public virtual DbSet<ServerModuleAndServiceList> ServerModuleAndServiceLists { get; set; } = null!;
        public virtual DbSet<ServerParameterList> ServerParameterLists { get; set; } = null!;
        public virtual DbSet<ServerProcessList> ServerProcessLists { get; set; } = null!;
        public virtual DbSet<ServerStaticOrMvcDefPathList> ServerStaticOrMvcDefPathLists { get; set; } = null!;
        public virtual DbSet<ServerToolPanelDefinitionList> ServerToolPanelDefinitionLists { get; set; } = null!;
        public virtual DbSet<ServerToolTypeList> ServerToolTypeLists { get; set; } = null!;
        public virtual DbSet<SolutionEmailTemplateList> SolutionEmailTemplateLists { get; set; } = null!;
        public virtual DbSet<SolutionEmailerHistoryList> SolutionEmailerHistoryLists { get; set; } = null!;
        public virtual DbSet<SolutionFailList> SolutionFailLists { get; set; } = null!;
        public virtual DbSet<SolutionLanguageList> SolutionLanguageLists { get; set; } = null!;
        public virtual DbSet<SolutionMessageModuleList> SolutionMessageModuleLists { get; set; } = null!;
        public virtual DbSet<SolutionMessageTypeList> SolutionMessageTypeLists { get; set; } = null!;
        public virtual DbSet<SolutionMixedEnumList> SolutionMixedEnumLists { get; set; } = null!;
        public virtual DbSet<SolutionMottoList> SolutionMottoLists { get; set; } = null!;
        public virtual DbSet<SolutionOperationList> SolutionOperationLists { get; set; } = null!;
        public virtual DbSet<SolutionSchedulerList> SolutionSchedulerLists { get; set; } = null!;
        public virtual DbSet<SolutionSchedulerProcessList> SolutionSchedulerProcessLists { get; set; } = null!;
        public virtual DbSet<SolutionStaticFileList> SolutionStaticFileLists { get; set; } = null!;
        public virtual DbSet<SolutionStaticFilePathList> SolutionStaticFilePathLists { get; set; } = null!;
        public virtual DbSet<SolutionStaticWebList> SolutionStaticWebLists { get; set; } = null!;
        public virtual DbSet<SolutionTaskList> SolutionTaskLists { get; set; } = null!;
        public virtual DbSet<SolutionUserList> SolutionUserLists { get; set; } = null!;
        public virtual DbSet<SolutionUserRoleList> SolutionUserRoleLists { get; set; } = null!;
        public virtual DbSet<SystemCustomPageList> SystemCustomPageLists { get; set; } = null!;
        public virtual DbSet<SystemDocumentAdviceList> SystemDocumentAdviceLists { get; set; } = null!;
        public virtual DbSet<SystemGroupMenuList> SystemGroupMenuLists { get; set; } = null!;
        public virtual DbSet<SystemIgnoredExceptionList> SystemIgnoredExceptionLists { get; set; } = null!;
        public virtual DbSet<SystemLoginHistoryList> SystemLoginHistoryLists { get; set; } = null!;
        public virtual DbSet<SystemMenuList> SystemMenuLists { get; set; } = null!;
        public virtual DbSet<SystemModuleList> SystemModuleLists { get; set; } = null!;
        public virtual DbSet<SystemReportList> SystemReportLists { get; set; } = null!;
        public virtual DbSet<SystemReportQueueList> SystemReportQueueLists { get; set; } = null!;
        public virtual DbSet<SystemSvgIconList> SystemSvgIconLists { get; set; } = null!;
        public virtual DbSet<SystemTranslationList> SystemTranslationLists { get; set; } = null!;
        public virtual DbSet<TemplateList> TemplateLists { get; set; } = null!;
        public virtual DbSet<UserAccessKeyList> UserAccessKeyLists { get; set; } = null!;
        public virtual DbSet<UserDbManagementList> UserDbManagementLists { get; set; } = null!;
        public virtual DbSet<UserImageGalleryList> UserImageGalleryLists { get; set; } = null!;
        public virtual DbSet<UserParameterList> UserParameterLists { get; set; } = null!;
        public virtual DbSet<WebBannedIpAddressList> WebBannedIpAddressLists { get; set; } = null!;
        public virtual DbSet<WebCodeLibraryList> WebCodeLibraryLists { get; set; } = null!;
        public virtual DbSet<WebConfiguratorList> WebConfiguratorLists { get; set; } = null!;
        public virtual DbSet<WebCoreFileList> WebCoreFileLists { get; set; } = null!;
        public virtual DbSet<WebDeveloperNewsList> WebDeveloperNewsLists { get; set; } = null!;
        public virtual DbSet<WebDocumentationCodeLibraryList> WebDocumentationCodeLibraryLists { get; set; } = null!;
        public virtual DbSet<WebDocumentationList> WebDocumentationLists { get; set; } = null!;
        public virtual DbSet<WebGlobalPageBlockList> WebGlobalPageBlockLists { get; set; } = null!;
        public virtual DbSet<WebGroupMenuList> WebGroupMenuLists { get; set; } = null!;
        public virtual DbSet<WebMenuList> WebMenuLists { get; set; } = null!;
        public virtual DbSet<WebSettingList> WebSettingLists { get; set; } = null!;
        public virtual DbSet<WebUserSettingList> WebUserSettingLists { get; set; } = null!;
        public virtual DbSet<WebVisitIpList> WebVisitIpLists { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicAttachmentList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicAttachmentLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttachmentList_UserList");
            });

            modelBuilder.Entity<BasicCalendarList>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Date })
                    .HasName("PK_Calendar");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicCalendarLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Calendar_UserList");
            });

            modelBuilder.Entity<BasicCurrencyList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicCurrencyLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrencyList_UserList");
            });

            modelBuilder.Entity<BasicImageGalleryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicImageGalleryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ImageGalleryList_UserList");
            });

            modelBuilder.Entity<BasicItemList>(entity =>
            {
                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.BasicItemLists)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_CurrencyList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BasicItemLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicItemLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_UserList");

                entity.HasOne(d => d.Vat)
                    .WithMany(p => p.BasicItemLists)
                    .HasForeignKey(d => d.VatId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemList_VatList");
            });

            modelBuilder.Entity<BasicUnitList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicUnitLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitList_UserList");
            });

            modelBuilder.Entity<BasicVatList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BasicVatLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VatList_UserList");
            });

            modelBuilder.Entity<BasicViewAttachmentList>(entity =>
            {
                entity.ToView("BasicViewAttachmentList");
            });

            modelBuilder.Entity<BusinessAddressList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessAddressLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AddressList_UserList");
            });

            modelBuilder.Entity<BusinessBranchList>(entity =>
            {
                entity.HasComment("");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessBranchLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BranchList_UserList");
            });

            modelBuilder.Entity<BusinessCreditNoteList>(entity =>
            {
                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.BusinessCreditNoteLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .HasConstraintName("FK_CreditNoteList_OutgoingInvoiceList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessCreditNoteLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessCreditNoteLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteList_UserList");
            });

            modelBuilder.Entity<BusinessCreditNoteSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessCreditNoteSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_CreditNoteItemList_CreditNoteList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessCreditNoteSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessCreditNoteSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteItemList_UserList");
            });

            modelBuilder.Entity<BusinessExchangeRateList>(entity =>
            {
                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.BusinessExchangeRateLists)
                    .HasForeignKey(d => d.CurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExchangeRateList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessExchangeRateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CourseList_UserList");
            });

            modelBuilder.Entity<BusinessIncomingInvoiceList>(entity =>
            {
                entity.HasOne(d => d.Maturity)
                    .WithMany(p => p.BusinessIncomingInvoiceLists)
                    .HasForeignKey(d => d.MaturityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_MaturityList");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.BusinessIncomingInvoiceLists)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_PaymentMethodList");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.BusinessIncomingInvoiceLists)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_PaymentStatusList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessIncomingInvoiceLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessIncomingInvoiceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceList_UserList");
            });

            modelBuilder.Entity<BusinessIncomingInvoiceSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessIncomingInvoiceSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_IncomingInvoiceItemList_IncomingInvoiceList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessIncomingInvoiceSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessIncomingInvoiceSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingInvoiceItemList_UserList");
            });

            modelBuilder.Entity<BusinessIncomingOrderList>(entity =>
            {
                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessIncomingOrderLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessIncomingOrderLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderList_UserList");
            });

            modelBuilder.Entity<BusinessIncomingOrderSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessIncomingOrderSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_IncomingOrderItemList_IncomingOrderList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessIncomingOrderSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessIncomingOrderSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IncomingOrderItemList_UserList");
            });

            modelBuilder.Entity<BusinessMaturityList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessMaturityLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaturityList_UserList");
            });

            modelBuilder.Entity<BusinessNotesList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessNotesLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NotesList_UserList");
            });

            modelBuilder.Entity<BusinessOfferList>(entity =>
            {
                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessOfferLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferList_CurrencyList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOfferLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferList_UserList");
            });

            modelBuilder.Entity<BusinessOfferSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessOfferSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OfferItemList_OfferList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOfferSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OfferItemList_UserList");
            });

            modelBuilder.Entity<BusinessOutgoingInvoiceList>(entity =>
            {
                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_CreditNoteList");

                entity.HasOne(d => d.Maturity)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.MaturityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_MaturityList");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_PaymentMethodList");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_PaymentStatusList");

                entity.HasOne(d => d.Receipt)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.ReceiptId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_ReceiptList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOutgoingInvoiceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceList_UserList");
            });

            modelBuilder.Entity<BusinessOutgoingInvoiceSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessOutgoingInvoiceSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_OutgoingInvoiceList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessOutgoingInvoiceSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOutgoingInvoiceSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingInvoiceItemList_UserList");
            });

            modelBuilder.Entity<BusinessOutgoingOrderList>(entity =>
            {
                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessOutgoingOrderLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOutgoingOrderLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderList_UserList");
            });

            modelBuilder.Entity<BusinessOutgoingOrderSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessOutgoingOrderSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_OutgoingOrderItemList_OutgoingOrderList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessOutgoingOrderSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessOutgoingOrderSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OutgoingOrderItemList_UserList");
            });

            modelBuilder.Entity<BusinessPaymentMethodList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessPaymentMethodLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentMethodList_UserList");
            });

            modelBuilder.Entity<BusinessPaymentStatusList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessPaymentStatusLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentStatusList_UserList");
            });

            modelBuilder.Entity<BusinessReceiptList>(entity =>
            {
                entity.HasOne(d => d.InvoiceNumberNavigation)
                    .WithMany(p => p.BusinessReceiptLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.InvoiceNumber)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_ReceiptList_OutgoingInvoiceList");

                entity.HasOne(d => d.TotalCurrency)
                    .WithMany(p => p.BusinessReceiptLists)
                    .HasForeignKey(d => d.TotalCurrencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptList_CurrencyList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessReceiptLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptList_UserList");
            });

            modelBuilder.Entity<BusinessReceiptSupportList>(entity =>
            {
                entity.HasOne(d => d.DocumentNumberNavigation)
                    .WithMany(p => p.BusinessReceiptSupportLists)
                    .HasPrincipalKey(p => p.DocumentNumber)
                    .HasForeignKey(d => d.DocumentNumber)
                    .HasConstraintName("FK_ReceiptItemList_ReceiptList");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.BusinessReceiptSupportLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItemList_UnitList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessReceiptSupportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReceiptItemList_UserList");
            });

            modelBuilder.Entity<BusinessWarehouseList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BusinessWarehouseLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarehouseList_UserList");
            });

            modelBuilder.Entity<DocSrvDocTemplateList>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DocSrvDocTemplateLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocSrvDocTemplateList_DocSrvDocumentationGroupList");

                entity.HasOne(d => d.InheritedCodeTypeNavigation)
                    .WithMany(p => p.DocSrvDocTemplateLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCodeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocSrvDocTemplateList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocSrvDocTemplateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocSrvDocTemplateList_UserList");
            });

            modelBuilder.Entity<DocSrvDocumentationCodeLibraryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocSrvDocumentationCodeLibraryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentationCodeLibraryList_UserList");
            });

            modelBuilder.Entity<DocSrvDocumentationGroupList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocSrvDocumentationGroupLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentationGroupList_UserList");
            });

            modelBuilder.Entity<DocSrvDocumentationList>(entity =>
            {
                entity.HasOne(d => d.DocumentationGroup)
                    .WithMany(p => p.DocSrvDocumentationLists)
                    .HasForeignKey(d => d.DocumentationGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentationList_DocumentationGroupList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DocSrvDocumentationLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentationList_UserList");
            });

            modelBuilder.Entity<GithubSrvAuthLogList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.GithubSrvAuthLogLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GithubSrvAuthLogList_UserId");
            });

            modelBuilder.Entity<GithubSrvRepositoryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.GithubSrvRepositoryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GithubSrvRepositoryList_SolutionUserList");
            });

            modelBuilder.Entity<GithubSrvSshKeyList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.GithubSrvSshKeyLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GithubSrvSshKeyList_UserId");
            });

            modelBuilder.Entity<GithubSrvTeamRepositoryRoleList>(entity =>
            {
                entity.HasOne(d => d.Repository)
                    .WithMany(p => p.GithubSrvTeamRepositoryRoleLists)
                    .HasForeignKey(d => d.RepositoryId)
                    .HasConstraintName("FK_GithubSrvTeamRepositoryRoleList_RepositoryId");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.GithubSrvTeamRepositoryRoleLists)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_GithubSrvTeamRepositoryRoleList_TeamId");
            });

            modelBuilder.Entity<GithubSrvUserTeamRoleList>(entity =>
            {
                entity.HasOne(d => d.Team)
                    .WithMany(p => p.GithubSrvUserTeamRoleLists)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("FK_GithubSrvUserTeamRoleList_TeamId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GithubSrvUserTeamRoleLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GithubSrvUserTeamRoleList_UserId");
            });

            modelBuilder.Entity<LicSrvLicenseAlgorithmList>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.LicSrvLicenseAlgorithmLists)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_AddressList");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.LicSrvLicenseAlgorithmLists)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_ItemList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LicSrvLicenseAlgorithmLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LicenseAlgorithmList_UserList");
            });

            modelBuilder.Entity<LicSrvUsedLicenseList>(entity =>
            {
                entity.HasOne(d => d.Address)
                    .WithMany(p => p.LicSrvUsedLicenseLists)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsedLicenseList_AddressList");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.LicSrvUsedLicenseLists)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsedLicenseList_ItemList");
            });

            modelBuilder.Entity<MigrationsHistoryList>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PK_MigrationsHistory");
            });

            modelBuilder.Entity<PortalActionHistoryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalActionHistoryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalActionHistoryList_SolutionUserList");
            });

            modelBuilder.Entity<PortalActionTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalActionTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalActionTypeList_SolutionUserList");
            });

            modelBuilder.Entity<PortalApiTableColumnDataList>(entity =>
            {
                entity.HasOne(d => d.ApiTableNavigation)
                    .WithMany(p => p.PortalApiTableColumnDataLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ApiTable)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnDataList_PortalApiTableList");

                entity.HasOne(d => d.ApiTableColumnNavigation)
                    .WithMany(p => p.PortalApiTableColumnDataListApiTableColumnNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.ApiTableColumn)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnDataList_PortalApiTableColumnList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalApiTableColumnDataListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnDataList_SolutionUserList");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.PortalApiTableColumnDataListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.UserDbPreffix)
                    .HasForeignKey(d => d.UserPrefix)
                    .HasConstraintName("FK_PortalApiTableColumnDataList_SolutionUserList1");

                entity.HasOne(d => d.PortalApiTableColumnList)
                    .WithMany(p => p.PortalApiTableColumnDataListPortalApiTableColumnLists)
                    .HasPrincipalKey(p => new { p.UserPrefix, p.ApiTable, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.ApiTable, d.ApiTableColumn })
                    .HasConstraintName("FK_PortalApiTableColumnDataList_PortalApiTableColumnList");
            });

            modelBuilder.Entity<PortalApiTableColumnList>(entity =>
            {
                entity.HasOne(d => d.InheritedDataTypeNavigation)
                    .WithMany(p => p.PortalApiTableColumnLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedDataType)
                    .HasConstraintName("FK_PortalApiTableColumnList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalApiTableColumnListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnList_SolutionUserList");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.PortalApiTableColumnListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.UserDbPreffix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnList_SolutionUserList1");

                entity.HasOne(d => d.PortalApiTableList)
                    .WithMany(p => p.PortalApiTableColumnLists)
                    .HasPrincipalKey(p => new { p.UserPrefix, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.ApiTable })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableColumnList_PortalApiTableList");
            });

            modelBuilder.Entity<PortalApiTableList>(entity =>
            {
                entity.HasOne(d => d.TableTypeNavigation)
                    .WithMany(p => p.PortalApiTableLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.TableType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableList_PortalApiTableTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalApiTableListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableList_SolutionUserList");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.PortalApiTableListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.UserDbPreffix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableList_SolutionUserList1");
            });

            modelBuilder.Entity<PortalApiTableTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalApiTableTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalApiTableTypeList_SolutionUserList");
            });

            modelBuilder.Entity<PortalDataHistoryList>(entity =>
            {
                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.PortalDataHistoryLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalDataHistoryList_PortalDataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalDataHistoryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalDataHistoryList_SolutionUserList");

                entity.HasOne(d => d.PortalApiTableList)
                    .WithMany(p => p.PortalDataHistoryLists)
                    .HasPrincipalKey(p => new { p.UserPrefix, p.Name })
                    .HasForeignKey(d => new { d.UserDbPreffix, d.TableName })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalDataHistoryList_PortalApiTableList");
            });

            modelBuilder.Entity<PortalDataTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalDataTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalDataTypeList_SolutionUserList");
            });

            modelBuilder.Entity<PortalGeneratedDataList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalGeneratedDataLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratedDataList_SolutionUserList");

                entity.HasOne(d => d.PortalGeneratorTypeList)
                    .WithMany(p => p.PortalGeneratedDataLists)
                    .HasPrincipalKey(p => new { p.UserDbPreffix, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.GeneratorType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratedDataList_PortalGeneratorTypeList");
            });

            modelBuilder.Entity<PortalGeneratorActionList>(entity =>
            {
                entity.HasOne(d => d.Generator)
                    .WithMany(p => p.PortalGeneratorActionLists)
                    .HasForeignKey(d => d.GeneratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorActionList_PortalGeneratorList");

                entity.HasOne(d => d.InheritedCommandTypeNavigation)
                    .WithMany(p => p.PortalGeneratorActionLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCommandType)
                    .HasConstraintName("FK_PortalGeneratorActionList_SolutionMixedEnumList");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.PortalGeneratorActionLists)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .HasConstraintName("FK_PortalGeneratorActionList_PortalTemplateTypeList");

                entity.HasOne(d => d.PortalGeneratorTypeList)
                    .WithMany(p => p.PortalGeneratorActionLists)
                    .HasPrincipalKey(p => new { p.UserDbPreffix, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.GeneratorType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorActionList_PortalGeneratorTypeList");
            });

            modelBuilder.Entity<PortalGeneratorList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalGeneratorLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorList_SolutionUserList");

                entity.HasOne(d => d.PortalGeneratorTypeList)
                    .WithMany(p => p.PortalGeneratorLists)
                    .HasPrincipalKey(p => new { p.UserDbPreffix, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.GeneratorType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorList_PortalGeneratorTypeList");
            });

            modelBuilder.Entity<PortalGeneratorTemplateList>(entity =>
            {
                entity.HasOne(d => d.Generator)
                    .WithMany(p => p.PortalGeneratorTemplateLists)
                    .HasForeignKey(d => d.GeneratorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorTemplateList_PortalGeneratorList");

                entity.HasOne(d => d.TemplateType)
                    .WithMany(p => p.PortalGeneratorTemplateLists)
                    .HasForeignKey(d => d.TemplateTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorTemplateList_PortalTemplateTypeList");
            });

            modelBuilder.Entity<PortalGeneratorTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalGeneratorTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalGeneratorTypeList_SolutionUserList");
            });

            modelBuilder.Entity<PortalHelpDataList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalHelpDataLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalHelpDataList_SolutionUserList");

                entity.HasOne(d => d.PortalHelpGroupList)
                    .WithMany(p => p.PortalHelpDataLists)
                    .HasPrincipalKey(p => new { p.UserPreffix, p.DataType, p.Name })
                    .HasForeignKey(d => new { d.UserPrefix, d.DataType, d.HelpGroupType })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalHelpDataList_PortalHelpGroupList");
            });

            modelBuilder.Entity<PortalHelpGroupList>(entity =>
            {
                entity.HasOne(d => d.DataTypeNavigation)
                    .WithMany(p => p.PortalHelpGroupLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.DataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalHelpGroupList_PortalDataTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalHelpGroupLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalHelpGroupList_SolutionUserList");
            });

            modelBuilder.Entity<PortalInjectGroupList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalInjectGroupLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalInjectGroupList_SolutionUserList");
            });

            modelBuilder.Entity<PortalInjectPageCodeList>(entity =>
            {
                entity.HasOne(d => d.InjectGroup)
                    .WithMany(p => p.PortalInjectPageCodeLists)
                    .HasForeignKey(d => d.InjectGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalInjectPageCodeList_PortalInjectGroupList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalInjectPageCodeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalInjectMarkList_SolutionUserList");
            });

            modelBuilder.Entity<PortalPluginList>(entity =>
            {
                entity.HasOne(d => d.InheritedCodeTypeNavigation)
                    .WithMany(p => p.PortalPluginListInheritedCodeTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCodeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalPluginList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedPluginTypeNavigation)
                    .WithMany(p => p.PortalPluginListInheritedPluginTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedPluginType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalPluginList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalPluginListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalPluginList_UserList");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.PortalPluginListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.UserDbPreffix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalPluginList_SolutionUserList");
            });

            modelBuilder.Entity<PortalTemplateTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalTemplateTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalTemplateTypeList_SolutionUserList");
            });

            modelBuilder.Entity<PortalUserCommentList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.PortalUserCommentLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PortalUserCommentList_SolutionUserList");
            });

            modelBuilder.Entity<ProdGuidGroupList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProdGuidGroupLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidGroupList_UserList");
            });

            modelBuilder.Entity<ProdGuidOperationList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProdGuidOperationLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidOperationList_UserList");
            });

            modelBuilder.Entity<ProdGuidPartList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProdGuidPartLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidPartList_UserList");
            });

            modelBuilder.Entity<ProdGuidPersonList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProdGuidPersonLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidPersonList_UserList");
            });

            modelBuilder.Entity<ProdGuidWorkList>(entity =>
            {
                entity.HasOne(d => d.PersonalNumberNavigation)
                    .WithMany(p => p.ProdGuidWorkLists)
                    .HasPrincipalKey(p => p.PersonalNumber)
                    .HasForeignKey(d => d.PersonalNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidWorkList_ProdGuidPersonList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProdGuidWorkLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdGuidWorkList_UserList");
            });

            modelBuilder.Entity<ServerApiSecurityList>(entity =>
            {
                entity.HasOne(d => d.InheritedApiTypeNavigation)
                    .WithMany(p => p.ServerApiSecurityLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedApiType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerApiSecurityList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerApiSecurityLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerApiSecurityList_UserList");
            });

            modelBuilder.Entity<ServerCorsDefAllowedOriginList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerCorsDefAllowedOriginLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerCorsDefAllowedOriginList_UserList");
            });

            modelBuilder.Entity<ServerHealthCheckTaskList>(entity =>
            {
                entity.HasOne(d => d.InheritedCheckTypeNavigation)
                    .WithMany(p => p.ServerHealthCheckTaskLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCheckType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerHealthCheckTaskList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerHealthCheckTaskLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HealthCheckTaskList_UserList");
            });

            modelBuilder.Entity<ServerLiveDataMonitorList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerLiveDataMonitorLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerLiveDataMonitorList_UserList");
            });

            modelBuilder.Entity<ServerModuleAndServiceList>(entity =>
            {
                entity.HasOne(d => d.InheritedLayoutTypeNavigation)
                    .WithMany(p => p.ServerModuleAndServiceListInheritedLayoutTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedLayoutType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerModuleAndServiceList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedPageTypeNavigation)
                    .WithMany(p => p.ServerModuleAndServiceListInheritedPageTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedPageType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerModuleAndServiceList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerModuleAndServiceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerModuleAndServiceList_UserList");
            });

            modelBuilder.Entity<ServerParameterList>(entity =>
            {
                entity.HasOne(d => d.InheritedDataTypeNavigation)
                    .WithMany(p => p.ServerParameterListInheritedDataTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedDataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerParameterList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedServerParamTypeNavigation)
                    .WithMany(p => p.ServerParameterListInheritedServerParamTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedServerParamType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerParameterList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerParameterLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerParameterList_SolutionUserList");
            });

            modelBuilder.Entity<ServerProcessList>(entity =>
            {
                entity.Property(e => e.UserPreffix).IsFixedLength();

                entity.HasOne(d => d.InheritedCommandTypeNavigation)
                    .WithMany(p => p.ServerProcessListInheritedCommandTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCommandType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerProcessList_SolutionMixedEnumList1");

                entity.HasOne(d => d.InheritedProcessTypeNavigation)
                    .WithMany(p => p.ServerProcessListInheritedProcessTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedProcessType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerProcessList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerProcessLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerProcessList_UserList");
            });

            modelBuilder.Entity<ServerStaticOrMvcDefPathList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerStaticOrMvcDefPathLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerStaticOrMvcDefPathList_UserList");
            });

            modelBuilder.Entity<ServerToolPanelDefinitionList>(entity =>
            {
                entity.HasOne(d => d.InheritedToolLinkTypeNavigation)
                    .WithMany(p => p.ServerToolPanelDefinitionLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedToolLinkType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerToolPanelDefinitionList_SolutionMixedEnumList");

                entity.HasOne(d => d.ToolType)
                    .WithMany(p => p.ServerToolPanelDefinitionLists)
                    .HasForeignKey(d => d.ToolTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerToolPanelDefinitionList_ToolTypeList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerToolPanelDefinitionLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerToolPanelDefinitionList_UserList");
            });

            modelBuilder.Entity<ServerToolTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerToolTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerToolTypeList_UserList");
            });

            modelBuilder.Entity<SolutionEmailTemplateList>(entity =>
            {
                entity.HasOne(d => d.SystemLanguage)
                    .WithMany(p => p.SolutionEmailTemplateLists)
                    .HasForeignKey(d => d.SystemLanguageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplateList_SystemLanguageList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionEmailTemplateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailTemplateList_UserList");
            });

            modelBuilder.Entity<SolutionFailList>(entity =>
            {
                entity.HasOne(d => d.InheritedLogMonitorTypeNavigation)
                    .WithMany(p => p.SolutionFailLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedLogMonitorType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionFailList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionFailLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SolutionFailList_UserList");
            });

            modelBuilder.Entity<SolutionLanguageList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionLanguageLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServerLanguageList_UserList");
            });

            modelBuilder.Entity<SolutionMessageModuleList>(entity =>
            {
                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.SolutionMessageModuleListFromUsers)
                    .HasForeignKey(d => d.FromUserId)
                    .HasConstraintName("FK_SolutionMessageModuleList_SolutionUserListFrom");

                entity.HasOne(d => d.MessageParent)
                    .WithMany(p => p.InverseMessageParent)
                    .HasForeignKey(d => d.MessageParentId)
                    .HasConstraintName("FK_SolutionMessageModuleList_SolutionMessageModuleListParent");

                entity.HasOne(d => d.MessageType)
                    .WithMany(p => p.SolutionMessageModuleLists)
                    .HasForeignKey(d => d.MessageTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionMessageModuleList_SolutionMessageTypeList");

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.SolutionMessageModuleListToUsers)
                    .HasForeignKey(d => d.ToUserId)
                    .HasConstraintName("FK_SolutionMessageModuleList_SolutionUserListTo");
            });

            modelBuilder.Entity<SolutionMessageTypeList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionMessageTypeLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionMessageTypeList_SolutionUserList");
            });

            modelBuilder.Entity<SolutionMixedEnumList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionMixedEnumLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GlobalMixedEnumList_UserList");
            });

            modelBuilder.Entity<SolutionMottoList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionMottoLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MottoList_UserList");
            });

            modelBuilder.Entity<SolutionOperationList>(entity =>
            {
                entity.HasOne(d => d.InheritedApiResultTypeNavigation)
                    .WithMany(p => p.SolutionOperationListInheritedApiResultTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedApiResultType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionOperationList_SolutionMixedEnumList1");

                entity.HasOne(d => d.InheritedOperationTypeNavigation)
                    .WithMany(p => p.SolutionOperationListInheritedOperationTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedOperationType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionOperationList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionOperationLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionOperationList_UserList");
            });

            modelBuilder.Entity<SolutionSchedulerList>(entity =>
            {
                entity.HasOne(d => d.InheritedGroupNameNavigation)
                    .WithMany(p => p.SolutionSchedulerListInheritedGroupNameNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedGroupName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionSchedulerList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedIntervalTypeNavigation)
                    .WithMany(p => p.SolutionSchedulerListInheritedIntervalTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedIntervalType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionSchedulerList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionSchedulerLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GlobalAutoSchedulerList_UserList");
            });

            modelBuilder.Entity<SolutionSchedulerProcessList>(entity =>
            {
                entity.HasOne(d => d.ScheduledTask)
                    .WithMany(p => p.SolutionSchedulerProcessLists)
                    .HasForeignKey(d => d.ScheduledTaskId)
                    .HasConstraintName("FK_SolutionSchedulerProcessList_SolutionSchedulerList");
            });

            modelBuilder.Entity<SolutionStaticFileList>(entity =>
            {
                entity.HasOne(d => d.StaticPath)
                    .WithMany(p => p.SolutionStaticFileLists)
                    .HasForeignKey(d => d.StaticPathId)
                    .HasConstraintName("FK_SolutionStaticFileList_SolutionStaticFilePathList");

                entity.HasOne(d => d.StaticWeb)
                    .WithMany(p => p.SolutionStaticFileLists)
                    .HasForeignKey(d => d.StaticWebId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionStaticFileList_SolutionStaticWebList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionStaticFileLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SolutionStaticFileList_UserList");
            });

            modelBuilder.Entity<SolutionStaticFilePathList>(entity =>
            {
                entity.HasOne(d => d.StaticWeb)
                    .WithMany(p => p.SolutionStaticFilePathLists)
                    .HasForeignKey(d => d.StaticWebId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionStaticFilePathList_SolutionStaticWebList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionStaticFilePathLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SolutionStaticFilePathList_UserList");
            });

            modelBuilder.Entity<SolutionStaticWebList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionStaticWebLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionStaticWebList_UserList");
            });

            modelBuilder.Entity<SolutionTaskList>(entity =>
            {
                entity.HasOne(d => d.InheritedStatusTypeNavigation)
                    .WithMany(p => p.SolutionTaskListInheritedStatusTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedStatusType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionTaskList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedTargetTypeNavigation)
                    .WithMany(p => p.SolutionTaskListInheritedTargetTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedTargetType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionTaskList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SolutionTaskLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionTaskList_UserList");
            });

            modelBuilder.Entity<SolutionUserList>(entity =>
            {
                entity.HasOne(d => d.RoleAccessValueNavigation)
                    .WithMany(p => p.SolutionUserListRoleAccessValueNavigations)
                    .HasPrincipalKey(p => p.MinimalAccessValue)
                    .HasForeignKey(d => d.RoleAccessValue)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SolutionUserList_SolutionUserRoleList");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SolutionUserListRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserList_UserRoleList");
            });

            modelBuilder.Entity<SystemCustomPageList>(entity =>
            {
                entity.HasOne(d => d.InheritedFormTypeNavigation)
                    .WithMany(p => p.SystemCustomPageListInheritedFormTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedFormType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemCustomPageList_SolutionMixedEnumList");

                entity.HasOne(d => d.InheritedSystemApiCallTypeNavigation)
                    .WithMany(p => p.SystemCustomPageListInheritedSystemApiCallTypeNavigations)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedSystemApiCallType)
                    .HasConstraintName("FK_SystemCustomPageList_SolutionMixedEnumList1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemCustomPageLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemCustomPageList_UserList");
            });

            modelBuilder.Entity<SystemDocumentAdviceList>(entity =>
            {
                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.SystemDocumentAdviceLists)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAdviceList_BranchList");

                entity.HasOne(d => d.InheritedDocumentTypeNavigation)
                    .WithMany(p => p.SystemDocumentAdviceLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedDocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemDocumentAdviceList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemDocumentAdviceLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentAdvice_UserList");
            });

            modelBuilder.Entity<SystemGroupMenuList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemGroupMenuLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemGroupMenuList_UserList");
            });

            modelBuilder.Entity<SystemIgnoredExceptionList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemIgnoredExceptionLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IgnoredExceptionList_UserList");
            });

            modelBuilder.Entity<SystemMenuList>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.SystemMenuLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemMenuList_SystemGroupMenuList");

                entity.HasOne(d => d.InheritedMenuTypeNavigation)
                    .WithMany(p => p.SystemMenuLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedMenuType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemMenuList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemMenuLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemMenuList_UserList");
            });

            modelBuilder.Entity<SystemModuleList>(entity =>
            {
                entity.HasOne(d => d.InheritedModuleTypeNavigation)
                    .WithMany(p => p.SystemModuleLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedModuleType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemModuleList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemModuleLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemModuleList_UserList");
            });

            modelBuilder.Entity<SystemReportList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemReportLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportList_UserList");
            });

            modelBuilder.Entity<SystemSvgIconList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemSvgIconLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SvgIconList_UserList");
            });

            modelBuilder.Entity<SystemTranslationList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.SystemTranslationLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SystemTranslationList_UserList");
            });

            modelBuilder.Entity<TemplateList>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.TemplateLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateList_UserRoleList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TemplateLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TemplateList_UserList");
            });

            modelBuilder.Entity<UserAccessKeyList>(entity =>
            {
                entity.HasOne(d => d.InheritedClientTypeNavigation)
                    .WithMany(p => p.UserAccessKeyLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedClientType)
                    .HasConstraintName("FK_UserAccessKeyList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserAccessKeyLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserAccessKeyList_SolutionUserList");
            });

            modelBuilder.Entity<UserDbManagementList>(entity =>
            {
                entity.HasOne(d => d.InheritedDbTypeNavigation)
                    .WithMany(p => p.UserDbManagementLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedDbType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDbManagementList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserDbManagementListUsers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDbManagementList_UserList");

                entity.HasOne(d => d.UserPrefixNavigation)
                    .WithMany(p => p.UserDbManagementListUserPrefixNavigations)
                    .HasPrincipalKey(p => p.UserDbPreffix)
                    .HasForeignKey(d => d.UserPrefix)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDbManagementList_SolutionUserList");
            });

            modelBuilder.Entity<UserImageGalleryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserImageGalleryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserImageGalleryList_UserList");
            });

            modelBuilder.Entity<UserParameterList>(entity =>
            {
                entity.HasOne(d => d.InheritedDataTypeNavigation)
                    .WithMany(p => p.UserParameterLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedDataType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserParameterList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserParameterLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ParameterList_UserList");
            });

            modelBuilder.Entity<WebBannedIpAddressList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebBannedIpAddressLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebBannedUserList_UserList");
            });

            modelBuilder.Entity<WebCodeLibraryList>(entity =>
            {
                entity.HasOne(d => d.InheritedCodeTypeNavigation)
                    .WithMany(p => p.WebCodeLibraryLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedCodeType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebCodeLibraryList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebCodeLibraryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebCodeLibraryList_UserList");
            });

            modelBuilder.Entity<WebConfiguratorList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebConfiguratorLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebConfiguratorList_UserList");
            });

            modelBuilder.Entity<WebCoreFileList>(entity =>
            {
                entity.HasOne(d => d.InheritedJsCssDefinitionTypeNavigation)
                    .WithMany(p => p.WebCoreFileLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedJsCssDefinitionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebCoreFileList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebCoreFileLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebCoreFileList_GlobalUserList");
            });

            modelBuilder.Entity<WebDeveloperNewsList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebDeveloperNewsLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebDeveloperNewsList_UserList");
            });

            modelBuilder.Entity<WebDocumentationCodeLibraryList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebDocumentationCodeLibraryLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebDocumentationCodeLibraryList_UserList");
            });

            modelBuilder.Entity<WebDocumentationList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebDocumentationLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebDocumentationList_UserList");
            });

            modelBuilder.Entity<WebGlobalPageBlockList>(entity =>
            {
                entity.HasOne(d => d.InheritedPagePartTypeNavigation)
                    .WithMany(p => p.WebGlobalPageBlockLists)
                    .HasPrincipalKey(p => p.Name)
                    .HasForeignKey(d => d.InheritedPagePartType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebGlobalPageBlockList_SolutionMixedEnumList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebGlobalPageBlockLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebGlobalBodyBlockList_UserList");
            });

            modelBuilder.Entity<WebGroupMenuList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebGroupMenuLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebGroupMenuList_UserList");
            });

            modelBuilder.Entity<WebMenuList>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.WebMenuLists)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebMenuList_WebGroupMenuList");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebMenuLists)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebMenuList_UserList");
            });

            modelBuilder.Entity<WebSettingList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebSettingLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WebSettingList_UserList");
            });

            modelBuilder.Entity<WebUserSettingList>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebUserSettingLists)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_WebUserSettingList_UserList");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
