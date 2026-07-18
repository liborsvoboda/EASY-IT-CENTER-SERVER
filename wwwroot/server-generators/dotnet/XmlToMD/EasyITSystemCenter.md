<a name='assembly'></a>
# EasyITSystemCenter

## Contents

- [AnimationLibrary](#T-EasyITSystemCenter-GlobalStyles-AnimationLibrary 'EasyITSystemCenter.GlobalStyles.AnimationLibrary')
- [ApiUrls](#T-EasyITSystemCenter-Api-ApiUrls 'EasyITSystemCenter.Api.ApiUrls')
- [App](#T-EasyITSystemCenter-App 'EasyITSystemCenter.App')
  - [#ctor()](#M-EasyITSystemCenter-App-#ctor 'EasyITSystemCenter.App.#ctor')
  - [TiltReceiptDoc](#F-EasyITSystemCenter-App-TiltReceiptDoc 'EasyITSystemCenter.App.TiltReceiptDoc')
  - [appRuntimeData](#F-EasyITSystemCenter-App-appRuntimeData 'EasyITSystemCenter.App.appRuntimeData')
  - [log](#F-EasyITSystemCenter-App-log 'EasyITSystemCenter.App.log')
  - [AppQuitRequest(silent)](#M-EasyITSystemCenter-App-AppQuitRequest-System-Boolean- 'EasyITSystemCenter.App.AppQuitRequest(System.Boolean)')
  - [AppRestart()](#M-EasyITSystemCenter-App-AppRestart 'EasyITSystemCenter.App.AppRestart')
  - [ApplicationLogging(ex,customMessage)](#M-EasyITSystemCenter-App-ApplicationLogging-System-Exception,System-String- 'EasyITSystemCenter.App.ApplicationLogging(System.Exception,System.String)')
  - [ApplicationQuit()](#M-EasyITSystemCenter-App-ApplicationQuit 'EasyITSystemCenter.App.ApplicationQuit')
  - [CurrentDomain_FirstChanceException(sender,e)](#M-EasyITSystemCenter-App-CurrentDomain_FirstChanceException-System-Object,System-Runtime-ExceptionServices-FirstChanceExceptionEventArgs- 'EasyITSystemCenter.App.CurrentDomain_FirstChanceException(System.Object,System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-App-InitializeComponent 'EasyITSystemCenter.App.InitializeComponent')
  - [Main()](#M-EasyITSystemCenter-App-Main 'EasyITSystemCenter.App.Main')
  - [OnStartup(e)](#M-EasyITSystemCenter-App-OnStartup-System-Windows-StartupEventArgs- 'EasyITSystemCenter.App.OnStartup(System.Windows.StartupEventArgs)')
  - [RootAppKeyDownController(sender,e)](#M-EasyITSystemCenter-App-RootAppKeyDownController-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.App.RootAppKeyDownController(System.Object,System.Windows.Input.KeyEventArgs)')
  - [StartupLocaslWebServer()](#M-EasyITSystemCenter-App-StartupLocaslWebServer 'EasyITSystemCenter.App.StartupLocaslWebServer')
- [AppRuntimeData](#T-EasyITSystemCenter-GlobalClasses-AppRuntimeData 'EasyITSystemCenter.GlobalClasses.AppRuntimeData')
  - [JsonSerializeOptions](#F-EasyITSystemCenter-GlobalClasses-AppRuntimeData-JsonSerializeOptions 'EasyITSystemCenter.GlobalClasses.AppRuntimeData.JsonSerializeOptions')
- [AppVersion](#T-EasyITSystemCenter-GlobalClasses-AppVersion 'EasyITSystemCenter.GlobalClasses.AppVersion')
- [AuthentificationResponse](#T-EasyITSystemCenter-GlobalClasses-AuthentificationResponse 'EasyITSystemCenter.GlobalClasses.AuthentificationResponse')
- [BasicAttachmentListPage](#T-EasyITSystemCenter-Pages-BasicAttachmentListPage 'EasyITSystemCenter.Pages.BasicAttachmentListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicAttachmentListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicAttachmentListPage.InitializeComponent')
- [BasicCalendarListPage](#T-EasyITSystemCenter-Pages-BasicCalendarListPage 'EasyITSystemCenter.Pages.BasicCalendarListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicCalendarListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicCalendarListPage.InitializeComponent')
- [BasicCurrencyListPage](#T-EasyITSystemCenter-Pages-BasicCurrencyListPage 'EasyITSystemCenter.Pages.BasicCurrencyListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicCurrencyListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicCurrencyListPage.InitializeComponent')
- [BasicImageGalleryListPage](#T-EasyITSystemCenter-Pages-BasicImageGalleryListPage 'EasyITSystemCenter.Pages.BasicImageGalleryListPage')
  - [ClearGallery()](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-ClearGallery 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.ClearGallery')
  - [GrayscaleClick(sender,e)](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-GrayscaleClick-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.GrayscaleClick(System.Object,System.Windows.RoutedEventArgs)')
  - [ImageChangesCancelClick(sender,e)](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-ImageChangesCancelClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.ImageChangesCancelClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.InitializeComponent')
  - [LoadFromServer()](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-LoadFromServer-System-Int32- 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.LoadFromServer(System.Int32)')
  - [RefreshViewPhoto(selectedPhotoId)](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-RefreshViewPhoto-System-Nullable{System-Int32}- 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.RefreshViewPhoto(System.Nullable{System.Int32})')
  - [SaveImageToServer(onlyThis)](#M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-SaveImageToServer-System-Nullable{System-Int32}- 'EasyITSystemCenter.Pages.BasicImageGalleryListPage.SaveImageToServer(System.Nullable{System.Int32})')
- [BasicItemListPage](#T-EasyITSystemCenter-Pages-BasicItemListPage 'EasyITSystemCenter.Pages.BasicItemListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicItemListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicItemListPage.InitializeComponent')
- [BasicUnitListPage](#T-EasyITSystemCenter-Pages-BasicUnitListPage 'EasyITSystemCenter.Pages.BasicUnitListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicUnitListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicUnitListPage.InitializeComponent')
- [BasicVatListPage](#T-EasyITSystemCenter-Pages-BasicVatListPage 'EasyITSystemCenter.Pages.BasicVatListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BasicVatListPage-InitializeComponent 'EasyITSystemCenter.Pages.BasicVatListPage.InitializeComponent')
- [BindableBase](#T-EasyITSystemCenter-Interact-BindableBase 'EasyITSystemCenter.Interact.BindableBase')
  - [OnPropertyChanged(propertyName)](#M-EasyITSystemCenter-Interact-BindableBase-OnPropertyChanged-System-String- 'EasyITSystemCenter.Interact.BindableBase.OnPropertyChanged(System.String)')
  - [SetProperty\`\`1(storage,value,propertyName)](#M-EasyITSystemCenter-Interact-BindableBase-SetProperty``1-``0@,``0,System-String- 'EasyITSystemCenter.Interact.BindableBase.SetProperty``1(``0@,``0,System.String)')
- [BraceFoldingStrategy](#T-EasyITSystemCenter-Tools-BraceFoldingStrategy 'EasyITSystemCenter.Tools.BraceFoldingStrategy')
  - [#ctor()](#M-EasyITSystemCenter-Tools-BraceFoldingStrategy-#ctor 'EasyITSystemCenter.Tools.BraceFoldingStrategy.#ctor')
  - [ClosingBrace](#P-EasyITSystemCenter-Tools-BraceFoldingStrategy-ClosingBrace 'EasyITSystemCenter.Tools.BraceFoldingStrategy.ClosingBrace')
  - [OpeningBrace](#P-EasyITSystemCenter-Tools-BraceFoldingStrategy-OpeningBrace 'EasyITSystemCenter.Tools.BraceFoldingStrategy.OpeningBrace')
  - [CreateNewFoldings()](#M-EasyITSystemCenter-Tools-BraceFoldingStrategy-CreateNewFoldings-ICSharpCode-AvalonEdit-Document-TextDocument,System-Int32@- 'EasyITSystemCenter.Tools.BraceFoldingStrategy.CreateNewFoldings(ICSharpCode.AvalonEdit.Document.TextDocument,System.Int32@)')
  - [CreateNewFoldings()](#M-EasyITSystemCenter-Tools-BraceFoldingStrategy-CreateNewFoldings-ICSharpCode-AvalonEdit-Document-ITextSource- 'EasyITSystemCenter.Tools.BraceFoldingStrategy.CreateNewFoldings(ICSharpCode.AvalonEdit.Document.ITextSource)')
- [BusinessAddressListPage](#T-EasyITSystemCenter-Pages-BusinessAddressListPage 'EasyITSystemCenter.Pages.BusinessAddressListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessAddressListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessAddressListPage.InitializeComponent')
- [BusinessBranchListPage](#T-EasyITSystemCenter-Pages-BusinessBranchListPage 'EasyITSystemCenter.Pages.BusinessBranchListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessBranchListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessBranchListPage.InitializeComponent')
- [BusinessCreditNoteListPage](#T-EasyITSystemCenter-Pages-BusinessCreditNoteListPage 'EasyITSystemCenter.Pages.BusinessCreditNoteListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessCreditNoteListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessCreditNoteListPage.InitializeComponent')
- [BusinessExchangeRateListPage](#T-EasyITSystemCenter-Pages-BusinessExchangeRateListPage 'EasyITSystemCenter.Pages.BusinessExchangeRateListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessExchangeRateListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessExchangeRateListPage.InitializeComponent')
- [BusinessIncomingInvoiceListPage](#T-EasyITSystemCenter-Pages-BusinessIncomingInvoiceListPage 'EasyITSystemCenter.Pages.BusinessIncomingInvoiceListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessIncomingInvoiceListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessIncomingInvoiceListPage.InitializeComponent')
- [BusinessIncomingOrderListPage](#T-EasyITSystemCenter-Pages-BusinessIncomingOrderListPage 'EasyITSystemCenter.Pages.BusinessIncomingOrderListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessIncomingOrderListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessIncomingOrderListPage.InitializeComponent')
- [BusinessMaturityListPage](#T-EasyITSystemCenter-Pages-BusinessMaturityListPage 'EasyITSystemCenter.Pages.BusinessMaturityListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessMaturityListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessMaturityListPage.InitializeComponent')
- [BusinessNotesListPage](#T-EasyITSystemCenter-Pages-BusinessNotesListPage 'EasyITSystemCenter.Pages.BusinessNotesListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessNotesListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessNotesListPage.InitializeComponent')
- [BusinessOfferListPage](#T-EasyITSystemCenter-Pages-BusinessOfferListPage 'EasyITSystemCenter.Pages.BusinessOfferListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessOfferListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessOfferListPage.InitializeComponent')
- [BusinessOutgoingInvoiceListPage](#T-EasyITSystemCenter-Pages-BusinessOutgoingInvoiceListPage 'EasyITSystemCenter.Pages.BusinessOutgoingInvoiceListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessOutgoingInvoiceListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessOutgoingInvoiceListPage.InitializeComponent')
- [BusinessOutgoingOrderListPage](#T-EasyITSystemCenter-Pages-BusinessOutgoingOrderListPage 'EasyITSystemCenter.Pages.BusinessOutgoingOrderListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessOutgoingOrderListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessOutgoingOrderListPage.InitializeComponent')
- [BusinessPaymentMethodListPage](#T-EasyITSystemCenter-Pages-BusinessPaymentMethodListPage 'EasyITSystemCenter.Pages.BusinessPaymentMethodListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessPaymentMethodListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessPaymentMethodListPage.InitializeComponent')
- [BusinessPaymentStatusListPage](#T-EasyITSystemCenter-Pages-BusinessPaymentStatusListPage 'EasyITSystemCenter.Pages.BusinessPaymentStatusListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessPaymentStatusListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessPaymentStatusListPage.InitializeComponent')
- [BusinessReceiptListPage](#T-EasyITSystemCenter-Pages-BusinessReceiptListPage 'EasyITSystemCenter.Pages.BusinessReceiptListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessReceiptListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessReceiptListPage.InitializeComponent')
- [BusinessWarehouseListPage](#T-EasyITSystemCenter-Pages-BusinessWarehouseListPage 'EasyITSystemCenter.Pages.BusinessWarehouseListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-BusinessWarehouseListPage-InitializeComponent 'EasyITSystemCenter.Pages.BusinessWarehouseListPage.InitializeComponent')
- [ClientSettingsPage](#T-EasyITSystemCenter-Pages-ClientSettingsPage 'EasyITSystemCenter.Pages.ClientSettingsPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ClientSettingsPage-InitializeComponent 'EasyITSystemCenter.Pages.ClientSettingsPage.InitializeComponent')
- [ColorizeAvalonEdit](#T-EasyITSystemCenter-Tools-ColorizeAvalonEdit 'EasyITSystemCenter.Tools.ColorizeAvalonEdit')
- [CommOperations](#T-EasyITSystemCenter-GlobalOperations-CommOperations 'EasyITSystemCenter.GlobalOperations.CommOperations')
- [CommunicationManager](#T-EasyITSystemCenter-Api-CommunicationManager 'EasyITSystemCenter.Api.CommunicationManager')
  - [ApiManagerGetRequest(UrlPrefix,UrlOrSubPath,UrlPathExtension)](#M-EasyITSystemCenter-Api-CommunicationManager-ApiManagerGetRequest-EasyITSystemCenter-GlobalClasses-UrlSourceTypes,System-String,System-String- 'EasyITSystemCenter.Api.CommunicationManager.ApiManagerGetRequest(EasyITSystemCenter.GlobalClasses.UrlSourceTypes,System.String,System.String)')
  - [ApiManagerPostRequest\`\`1(UrlPrefix,UrlOrSubPath,htmlContent,UrlPathExtension)](#M-EasyITSystemCenter-Api-CommunicationManager-ApiManagerPostRequest``1-EasyITSystemCenter-GlobalClasses-UrlSourceTypes,System-String,System-Net-Http-HttpContent,System-String- 'EasyITSystemCenter.Api.CommunicationManager.ApiManagerPostRequest``1(EasyITSystemCenter.GlobalClasses.UrlSourceTypes,System.String,System.Net.Http.HttpContent,System.String)')
- [CrashReporterSettings](#T-EasyITSystemCenter-SystemConfiguration-CrashReporterSettings 'EasyITSystemCenter.SystemConfiguration.CrashReporterSettings')
  - [_ReportCrash](#F-EasyITSystemCenter-SystemConfiguration-CrashReporterSettings-_ReportCrash 'EasyITSystemCenter.SystemConfiguration.CrashReporterSettings._ReportCrash')
- [CustomMessageList](#T-EasyITSystemCenter-GlobalClasses-CustomMessageList 'EasyITSystemCenter.GlobalClasses.CustomMessageList')
- [DBOperations](#T-EasyITSystemCenter-GlobalOperations-DBOperations 'EasyITSystemCenter.GlobalOperations.DBOperations')
  - [DBTranslation(systemName,notCreateNew,comaList,lang)](#M-EasyITSystemCenter-GlobalOperations-DBOperations-DBTranslation-System-String,System-Boolean,System-Boolean,System-String- 'EasyITSystemCenter.GlobalOperations.DBOperations.DBTranslation(System.String,System.Boolean,System.Boolean,System.String)')
  - [LoadInheritedDataList(groupName)](#M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadInheritedDataList-System-String- 'EasyITSystemCenter.GlobalOperations.DBOperations.LoadInheritedDataList(System.String)')
  - [LoadOrRefreshUserData()](#M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadOrRefreshUserData 'EasyITSystemCenter.GlobalOperations.DBOperations.LoadOrRefreshUserData')
  - [LoadStartupDBData()](#M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadStartupDBData 'EasyITSystemCenter.GlobalOperations.DBOperations.LoadStartupDBData')
  - [LoadWaitingDataInSleepMode()](#M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadWaitingDataInSleepMode 'EasyITSystemCenter.GlobalOperations.DBOperations.LoadWaitingDataInSleepMode')
  - [SaveSystemFailMessage(message,logLevel)](#M-EasyITSystemCenter-GlobalOperations-DBOperations-SaveSystemFailMessage-System-String,System-String- 'EasyITSystemCenter.GlobalOperations.DBOperations.SaveSystemFailMessage(System.String,System.String)')
  - [SetNonUserDataOnSuccessStartUp()](#M-EasyITSystemCenter-GlobalOperations-DBOperations-SetNonUserDataOnSuccessStartUp 'EasyITSystemCenter.GlobalOperations.DBOperations.SetNonUserDataOnSuccessStartUp')
- [DBResult](#T-EasyITSystemCenter-GlobalClasses-DBResult 'EasyITSystemCenter.GlobalClasses.DBResult')
- [DBResultMessage](#T-EasyITSystemCenter-Api-DBResultMessage 'EasyITSystemCenter.Api.DBResultMessage')
- [DataOperations](#T-EasyITSystemCenter-GlobalOperations-DataOperations 'EasyITSystemCenter.GlobalOperations.DataOperations')
  - [ConvertDataTableToXml(dataTable,tablename)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertDataTableToXml-System-Data-DataTable,System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.ConvertDataTableToXml(System.Data.DataTable,System.String)')
  - [ConvertDictionaryListToJson(keyList)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertDictionaryListToJson-System-Collections-Generic-Dictionary{System-String,System-String}- 'EasyITSystemCenter.GlobalOperations.DataOperations.ConvertDictionaryListToJson(System.Collections.Generic.Dictionary{System.String,System.String})')
  - [ConvertGenericClassListToStandard\`\`1(data)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertGenericClassListToStandard``1-``0- 'EasyITSystemCenter.GlobalOperations.DataOperations.ConvertGenericClassListToStandard``1(``0)')
  - [ConvertGenericClassToStandard\`\`1(data)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertGenericClassToStandard``1-``0- 'EasyITSystemCenter.GlobalOperations.DataOperations.ConvertGenericClassToStandard``1(``0)')
  - [ConvertTableToClassListByType(dt,classType)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertTableToClassListByType-System-Data-DataTable,System-Type- 'EasyITSystemCenter.GlobalOperations.DataOperations.ConvertTableToClassListByType(System.Data.DataTable,System.Type)')
  - [GenericConvertTableToClassList\`\`1(dt)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-GenericConvertTableToClassList``1-System-Data-DataTable- 'EasyITSystemCenter.GlobalOperations.DataOperations.GenericConvertTableToClassList``1(System.Data.DataTable)')
  - [GenericToEnum\`\`1(value)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-GenericToEnum``1-System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.GenericToEnum``1(System.String)')
  - [IgnoreCaseReplaceString(originalValue,replaceFrom,ReplaceTo)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-IgnoreCaseReplaceString-System-String,System-String,System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.IgnoreCaseReplaceString(System.String,System.String,System.String)')
  - [NullSetInExtensionFields\`\`1()](#M-EasyITSystemCenter-GlobalOperations-DataOperations-NullSetInExtensionFields``1-``0@- 'EasyITSystemCenter.GlobalOperations.DataOperations.NullSetInExtensionFields``1(``0@)')
  - [ObjectToJson(obj)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ObjectToJson-System-Object- 'EasyITSystemCenter.GlobalOperations.DataOperations.ObjectToJson(System.Object)')
  - [ParameterCheck(parameterName)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-ParameterCheck-System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.ParameterCheck(System.String)')
  - [RemoveDiacritism(Text)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-RemoveDiacritism-System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.RemoveDiacritism(System.String)')
  - [StringToByteArray(input)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-StringToByteArray-System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.StringToByteArray(System.String)')
  - [Utf8toUnicode(utf8String)](#M-EasyITSystemCenter-GlobalOperations-DataOperations-Utf8toUnicode-System-String- 'EasyITSystemCenter.GlobalOperations.DataOperations.Utf8toUnicode(System.String)')
- [DataResources](#T-EasyITSystemCenter-DataResources 'EasyITSystemCenter.DataResources')
  - [GetImageResource(resourceFile)](#M-EasyITSystemCenter-DataResources-GetImageResource-System-String- 'EasyITSystemCenter.DataResources.GetImageResource(System.String)')
  - [GetMediaResource(resourceFile)](#M-EasyITSystemCenter-DataResources-GetMediaResource-System-String- 'EasyITSystemCenter.DataResources.GetMediaResource(System.String)')
- [DataViewSupport](#T-EasyITSystemCenter-GlobalClasses-DataViewSupport 'EasyITSystemCenter.GlobalClasses.DataViewSupport')
- [DelegateCommand](#T-EasyITSystemCenter-Interact-DelegateCommand 'EasyITSystemCenter.Interact.DelegateCommand')
  - [#ctor(execute)](#M-EasyITSystemCenter-Interact-DelegateCommand-#ctor-System-Action- 'EasyITSystemCenter.Interact.DelegateCommand.#ctor(System.Action)')
  - [#ctor(execute,canExecute)](#M-EasyITSystemCenter-Interact-DelegateCommand-#ctor-System-Action,System-Func{System-Boolean}- 'EasyITSystemCenter.Interact.DelegateCommand.#ctor(System.Action,System.Func{System.Boolean})')
  - [CanExecute(parameter)](#M-EasyITSystemCenter-Interact-DelegateCommand-CanExecute-System-Object- 'EasyITSystemCenter.Interact.DelegateCommand.CanExecute(System.Object)')
  - [Execute(parameter)](#M-EasyITSystemCenter-Interact-DelegateCommand-Execute-System-Object- 'EasyITSystemCenter.Interact.DelegateCommand.Execute(System.Object)')
  - [RaiseCanExecuteChanged()](#M-EasyITSystemCenter-Interact-DelegateCommand-RaiseCanExecuteChanged 'EasyITSystemCenter.Interact.DelegateCommand.RaiseCanExecuteChanged')
- [DeserializedJson](#T-EasyITSystemCenter-GlobalClasses-DeserializedJson 'EasyITSystemCenter.GlobalClasses.DeserializedJson')
- [DocSrvDocTemplateListPage](#T-EasyITSystemCenter-Pages-DocSrvDocTemplateListPage 'EasyITSystemCenter.Pages.DocSrvDocTemplateListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-DocSrvDocTemplateListPage-InitializeComponent 'EasyITSystemCenter.Pages.DocSrvDocTemplateListPage.InitializeComponent')
- [DocSrvDocumentationCodeLibraryListPage](#T-EasyITSystemCenter-Pages-DocSrvDocumentationCodeLibraryListPage 'EasyITSystemCenter.Pages.DocSrvDocumentationCodeLibraryListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-DocSrvDocumentationCodeLibraryListPage-InitializeComponent 'EasyITSystemCenter.Pages.DocSrvDocumentationCodeLibraryListPage.InitializeComponent')
- [DocSrvDocumentationGroupListPage](#T-EasyITSystemCenter-Pages-DocSrvDocumentationGroupListPage 'EasyITSystemCenter.Pages.DocSrvDocumentationGroupListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-DocSrvDocumentationGroupListPage-InitializeComponent 'EasyITSystemCenter.Pages.DocSrvDocumentationGroupListPage.InitializeComponent')
- [DocSrvDocumentationListPage](#T-EasyITSystemCenter-Pages-DocSrvDocumentationListPage 'EasyITSystemCenter.Pages.DocSrvDocumentationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-DocSrvDocumentationListPage-InitializeComponent 'EasyITSystemCenter.Pages.DocSrvDocumentationListPage.InitializeComponent')
- [DocumentItemList](#T-EasyITSystemCenter-GlobalClasses-DocumentItemList 'EasyITSystemCenter.GlobalClasses.DocumentItemList')
- [EffectLibrary](#T-EasyITSystemCenter-GlobalStyles-EffectLibrary 'EasyITSystemCenter.GlobalStyles.EffectLibrary')
  - [GetAnimationEffect()](#M-EasyITSystemCenter-GlobalStyles-EffectLibrary-GetAnimationEffect-System-Windows-FrameworkElement,EasyITSystemCenter-GlobalStyles-AnimationLibrary,EasyITSystemCenter-GlobalStyles-EffectTypes,EasyITSystemCenter-GlobalStyles-TriggerTypes,System-Double,System-Int32- 'EasyITSystemCenter.GlobalStyles.EffectLibrary.GetAnimationEffect(System.Windows.FrameworkElement,EasyITSystemCenter.GlobalStyles.AnimationLibrary,EasyITSystemCenter.GlobalStyles.EffectTypes,EasyITSystemCenter.GlobalStyles.TriggerTypes,System.Double,System.Int32)')
- [EffectTypes](#T-EasyITSystemCenter-GlobalStyles-EffectTypes 'EasyITSystemCenter.GlobalStyles.EffectTypes')
- [ExternalWebAppPage](#T-EasyITSystemCenter-Pages-ExternalWebAppPage 'EasyITSystemCenter.Pages.ExternalWebAppPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ExternalWebAppPage-InitializeComponent 'EasyITSystemCenter.Pages.ExternalWebAppPage.InitializeComponent')
- [FileOperations](#T-EasyITSystemCenter-GlobalOperations-FileOperations 'EasyITSystemCenter.GlobalOperations.FileOperations')
  - [ByteArrayToFile(fileName,byteArray)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-ByteArrayToFile-System-String,System-Byte[]- 'EasyITSystemCenter.GlobalOperations.FileOperations.ByteArrayToFile(System.String,System.Byte[])')
  - [CheckDirectory(directory)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CheckDirectory-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CheckDirectory(System.String)')
  - [CheckFile(file)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CheckFile-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CheckFile(System.String)')
  - [ClearFolder(FolderName)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-ClearFolder-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.ClearFolder(System.String)')
  - [ConvertSystemFilePathFromUrl(webpath)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-ConvertSystemFilePathFromUrl-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.ConvertSystemFilePathFromUrl(System.String)')
  - [CopyDirectory(directory)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyDirectory-System-String,System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CopyDirectory(System.String,System.String)')
  - [CopyFile(from,to)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyFile-System-String,System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CopyFile(System.String,System.String)')
  - [CopyFiles(sourcePath,destinationPath)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyFiles-System-String,System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CopyFiles(System.String,System.String)')
  - [CreateDirectory(directory)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CreateDirectory-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CreateDirectory(System.String)')
  - [CreateFile(file)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CreateFile-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.CreateFile(System.String)')
  - [CreatePath(path,clearIfExist)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-CreatePath-System-String,System-Boolean- 'EasyITSystemCenter.GlobalOperations.FileOperations.CreatePath(System.String,System.Boolean)')
  - [DeleteDirectory(directory)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-DeleteDirectory-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.DeleteDirectory(System.String)')
  - [DeleteFile(file)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-DeleteFile-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.DeleteFile(System.String)')
  - [FileDetectEncoding(FileName)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-FileDetectEncoding-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.FileDetectEncoding(System.String)')
  - [GetPathFiles(sourcePath,fileMask,searchOption)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-GetPathFiles-System-String,System-String,System-IO-SearchOption- 'EasyITSystemCenter.GlobalOperations.FileOperations.GetPathFiles(System.String,System.String,System.IO.SearchOption)')
  - [LoadSettings()](#M-EasyITSystemCenter-GlobalOperations-FileOperations-LoadSettings 'EasyITSystemCenter.GlobalOperations.FileOperations.LoadSettings')
  - [ReadFile(fileName)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-ReadFile-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.ReadFile(System.String)')
  - [SaveSettings()](#M-EasyITSystemCenter-GlobalOperations-FileOperations-SaveSettings 'EasyITSystemCenter.GlobalOperations.FileOperations.SaveSettings')
  - [UnicodeToUTF8(strFrom)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-UnicodeToUTF8-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.UnicodeToUTF8(System.String)')
  - [VncServerIniFile(path)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-VncServerIniFile-System-String- 'EasyITSystemCenter.GlobalOperations.FileOperations.VncServerIniFile(System.String)')
  - [WriteToFile(file,content,rewrite)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-WriteToFile-System-String,System-String,System-Boolean- 'EasyITSystemCenter.GlobalOperations.FileOperations.WriteToFile(System.String,System.String,System.Boolean)')
- [FormOperations](#T-EasyITSystemCenter-GlobalOperations-FormOperations 'EasyITSystemCenter.GlobalOperations.FormOperations')
  - [AnalphabetAndNumericOnlyValidated()](#M-EasyITSystemCenter-GlobalOperations-FormOperations-AnalphabetAndNumericOnlyValidated-System-Windows-Input-TextCompositionEventArgs@,System-Boolean- 'EasyITSystemCenter.GlobalOperations.FormOperations.AnalphabetAndNumericOnlyValidated(System.Windows.Input.TextCompositionEventArgs@,System.Boolean)')
  - [DisplayAllToolTips_OnClick(userControl)](#M-EasyITSystemCenter-GlobalOperations-FormOperations-DisplayAllToolTips_OnClick-System-Windows-FrameworkElement- 'EasyITSystemCenter.GlobalOperations.FormOperations.DisplayAllToolTips_OnClick(System.Windows.FrameworkElement)')
  - [FindVisualChildren\`\`1(depObj)](#M-EasyITSystemCenter-GlobalOperations-FormOperations-FindVisualChildren``1-System-Windows-DependencyObject- 'EasyITSystemCenter.GlobalOperations.FormOperations.FindVisualChildren``1(System.Windows.DependencyObject)')
  - [NumberOnlyValidated()](#M-EasyITSystemCenter-GlobalOperations-FormOperations-NumberOnlyValidated-System-String- 'EasyITSystemCenter.GlobalOperations.FormOperations.NumberOnlyValidated(System.String)')
  - [RemoveDisabledSpacesFromTextInput()](#M-EasyITSystemCenter-GlobalOperations-FormOperations-RemoveDisabledSpacesFromTextInput-System-Object@,System-Windows-Controls-TextChangedEventArgs@- 'EasyITSystemCenter.GlobalOperations.FormOperations.RemoveDisabledSpacesFromTextInput(System.Object@,System.Windows.Controls.TextChangedEventArgs@)')
  - [TranslateFormFields(parentObject)](#M-EasyITSystemCenter-GlobalOperations-FormOperations-TranslateFormFields-System-Windows-DependencyObject- 'EasyITSystemCenter.GlobalOperations.FormOperations.TranslateFormFields(System.Windows.DependencyObject)')
  - [TranslateSubObjectsNameToToolTip\`\`1(parentObject)](#M-EasyITSystemCenter-GlobalOperations-FormOperations-TranslateSubObjectsNameToToolTip``1-``0- 'EasyITSystemCenter.GlobalOperations.FormOperations.TranslateSubObjectsNameToToolTip``1(``0)')
- [FrameAnimator](#T-EasyITSystemCenter-Interact-FrameAnimator 'EasyITSystemCenter.Interact.FrameAnimator')
  - [GetFrameNavigationStoryboard(control)](#M-EasyITSystemCenter-Interact-FrameAnimator-GetFrameNavigationStoryboard-System-Windows-DependencyObject- 'EasyITSystemCenter.Interact.FrameAnimator.GetFrameNavigationStoryboard(System.Windows.DependencyObject)')
  - [SetFrameNavigationStoryboard(control,storyboard)](#M-EasyITSystemCenter-Interact-FrameAnimator-SetFrameNavigationStoryboard-System-Windows-DependencyObject,System-Windows-Media-Animation-Storyboard- 'EasyITSystemCenter.Interact.FrameAnimator.SetFrameNavigationStoryboard(System.Windows.DependencyObject,System.Windows.Media.Animation.Storyboard)')
- [GeneratedInternalTypeHelper](#T-XamlGeneratedNamespace-GeneratedInternalTypeHelper 'XamlGeneratedNamespace.GeneratedInternalTypeHelper')
  - [AddEventHandler()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.AddEventHandler(System.Reflection.EventInfo,System.Object,System.Delegate)')
  - [CreateDelegate()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateDelegate(System.Type,System.Object,System.String)')
  - [CreateInstance()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.CreateInstance(System.Type,System.Globalization.CultureInfo)')
  - [GetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.GetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Globalization.CultureInfo)')
  - [SetPropertyValue()](#M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo- 'XamlGeneratedNamespace.GeneratedInternalTypeHelper.SetPropertyValue(System.Reflection.PropertyInfo,System.Object,System.Object,System.Globalization.CultureInfo)')
- [GenericDataList](#T-EasyITSystemCenter-GlobalClasses-GenericDataList 'EasyITSystemCenter.GlobalClasses.GenericDataList')
- [GenericTable](#T-EasyITSystemCenter-GlobalClasses-GenericTable 'EasyITSystemCenter.GlobalClasses.GenericTable')
- [GenericValue](#T-EasyITSystemCenter-GlobalClasses-GenericValue 'EasyITSystemCenter.GlobalClasses.GenericValue')
- [GraphsPage](#T-EasyITSystemCenter-Pages-GraphsPage 'EasyITSystemCenter.Pages.GraphsPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-GraphsPage-InitializeComponent 'EasyITSystemCenter.Pages.GraphsPage.InitializeComponent')
- [HardwareOperations](#T-EasyITSystemCenter-GlobalOperations-HardwareOperations 'EasyITSystemCenter.GlobalOperations.HardwareOperations')
  - [ApplicationKeyboardMaping(e)](#M-EasyITSystemCenter-GlobalOperations-HardwareOperations-ApplicationKeyboardMaping-System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.GlobalOperations.HardwareOperations.ApplicationKeyboardMaping(System.Windows.Input.KeyEventArgs)')
- [HostWin32AppPage](#T-EasyITSystemCenter-Pages-HostWin32AppPage 'EasyITSystemCenter.Pages.HostWin32AppPage')
  - [_appWin](#F-EasyITSystemCenter-Pages-HostWin32AppPage-_appWin 'EasyITSystemCenter.Pages.HostWin32AppPage._appWin')
  - [_iscreated](#F-EasyITSystemCenter-Pages-HostWin32AppPage-_iscreated 'EasyITSystemCenter.Pages.HostWin32AppPage._iscreated')
  - [_isdisposed](#F-EasyITSystemCenter-Pages-HostWin32AppPage-_isdisposed 'EasyITSystemCenter.Pages.HostWin32AppPage._isdisposed')
  - [exeName](#F-EasyITSystemCenter-Pages-HostWin32AppPage-exeName 'EasyITSystemCenter.Pages.HostWin32AppPage.exeName')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-HostWin32AppPage-InitializeComponent 'EasyITSystemCenter.Pages.HostWin32AppPage.InitializeComponent')
  - [OnResize(e)](#M-EasyITSystemCenter-Pages-HostWin32AppPage-OnResize-System-Object,System-Windows-SizeChangedEventArgs- 'EasyITSystemCenter.Pages.HostWin32AppPage.OnResize(System.Object,System.Windows.SizeChangedEventArgs)')
  - [OnSizeChanged(e)](#M-EasyITSystemCenter-Pages-HostWin32AppPage-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs- 'EasyITSystemCenter.Pages.HostWin32AppPage.OnSizeChanged(System.Object,System.Windows.SizeChangedEventArgs)')
  - [OnVisibleChanged(e)](#M-EasyITSystemCenter-Pages-HostWin32AppPage-OnVisibleChanged-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.HostWin32AppPage.OnVisibleChanged(System.Object,System.Windows.RoutedEventArgs)')
- [HtmlFullEditorPage](#T-EasyITSystemCenter-Pages-HtmlFullEditorPage 'EasyITSystemCenter.Pages.HtmlFullEditorPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-HtmlFullEditorPage-InitializeComponent 'EasyITSystemCenter.Pages.HtmlFullEditorPage.InitializeComponent')
- [ITextMarker](#T-EasyITSystemCenter-Tools-ITextMarker 'EasyITSystemCenter.Tools.ITextMarker')
  - [BackgroundColor](#P-EasyITSystemCenter-Tools-ITextMarker-BackgroundColor 'EasyITSystemCenter.Tools.ITextMarker.BackgroundColor')
  - [EndOffset](#P-EasyITSystemCenter-Tools-ITextMarker-EndOffset 'EasyITSystemCenter.Tools.ITextMarker.EndOffset')
  - [FontStyle](#P-EasyITSystemCenter-Tools-ITextMarker-FontStyle 'EasyITSystemCenter.Tools.ITextMarker.FontStyle')
  - [FontWeight](#P-EasyITSystemCenter-Tools-ITextMarker-FontWeight 'EasyITSystemCenter.Tools.ITextMarker.FontWeight')
  - [ForegroundColor](#P-EasyITSystemCenter-Tools-ITextMarker-ForegroundColor 'EasyITSystemCenter.Tools.ITextMarker.ForegroundColor')
  - [IsDeleted](#P-EasyITSystemCenter-Tools-ITextMarker-IsDeleted 'EasyITSystemCenter.Tools.ITextMarker.IsDeleted')
  - [Length](#P-EasyITSystemCenter-Tools-ITextMarker-Length 'EasyITSystemCenter.Tools.ITextMarker.Length')
  - [MarkerColor](#P-EasyITSystemCenter-Tools-ITextMarker-MarkerColor 'EasyITSystemCenter.Tools.ITextMarker.MarkerColor')
  - [MarkerTypes](#P-EasyITSystemCenter-Tools-ITextMarker-MarkerTypes 'EasyITSystemCenter.Tools.ITextMarker.MarkerTypes')
  - [StartOffset](#P-EasyITSystemCenter-Tools-ITextMarker-StartOffset 'EasyITSystemCenter.Tools.ITextMarker.StartOffset')
  - [Tag](#P-EasyITSystemCenter-Tools-ITextMarker-Tag 'EasyITSystemCenter.Tools.ITextMarker.Tag')
  - [ToolTip](#P-EasyITSystemCenter-Tools-ITextMarker-ToolTip 'EasyITSystemCenter.Tools.ITextMarker.ToolTip')
  - [Delete()](#M-EasyITSystemCenter-Tools-ITextMarker-Delete 'EasyITSystemCenter.Tools.ITextMarker.Delete')
- [ITextMarkerService](#T-EasyITSystemCenter-Tools-ITextMarkerService 'EasyITSystemCenter.Tools.ITextMarkerService')
  - [TextMarkers](#P-EasyITSystemCenter-Tools-ITextMarkerService-TextMarkers 'EasyITSystemCenter.Tools.ITextMarkerService.TextMarkers')
  - [Create()](#M-EasyITSystemCenter-Tools-ITextMarkerService-Create-System-Int32,System-Int32- 'EasyITSystemCenter.Tools.ITextMarkerService.Create(System.Int32,System.Int32)')
  - [GetMarkersAtOffset()](#M-EasyITSystemCenter-Tools-ITextMarkerService-GetMarkersAtOffset-System-Int32- 'EasyITSystemCenter.Tools.ITextMarkerService.GetMarkersAtOffset(System.Int32)')
  - [Remove()](#M-EasyITSystemCenter-Tools-ITextMarkerService-Remove-EasyITSystemCenter-Tools-ITextMarker- 'EasyITSystemCenter.Tools.ITextMarkerService.Remove(EasyITSystemCenter.Tools.ITextMarker)')
  - [RemoveAll()](#M-EasyITSystemCenter-Tools-ITextMarkerService-RemoveAll-System-Predicate{EasyITSystemCenter-Tools-ITextMarker}- 'EasyITSystemCenter.Tools.ITextMarkerService.RemoveAll(System.Predicate{EasyITSystemCenter.Tools.ITextMarker})')
- [IconMaker](#T-EasyITSystemCenter-GlobalGenerators-IconMaker 'EasyITSystemCenter.GlobalGenerators.IconMaker')
  - [Icon(color,iconPath)](#M-EasyITSystemCenter-GlobalGenerators-IconMaker-Icon-System-Windows-Media-Color,System-String- 'EasyITSystemCenter.GlobalGenerators.IconMaker.Icon(System.Windows.Media.Color,System.String)')
- [ImageElementGenerator](#T-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator 'EasyITSystemCenter.GlobalGenerators.ImageElementGenerator')
  - [ConstructElement()](#M-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator-ConstructElement-System-Int32- 'EasyITSystemCenter.GlobalGenerators.ImageElementGenerator.ConstructElement(System.Int32)')
  - [GetFirstInterestedOffset()](#M-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator-GetFirstInterestedOffset-System-Int32- 'EasyITSystemCenter.GlobalGenerators.ImageElementGenerator.GetFirstInterestedOffset(System.Int32)')
- [InteractAboutPage](#T-EasyITSystemCenter-Interact-InteractAboutPage 'EasyITSystemCenter.Interact.InteractAboutPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractAboutPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractAboutPage.InitializeComponent')
- [InteractAwesomePage](#T-EasyITSystemCenter-Interact-InteractAwesomePage 'EasyITSystemCenter.Interact.InteractAwesomePage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractAwesomePage-InitializeComponent 'EasyITSystemCenter.Interact.InteractAwesomePage.InitializeComponent')
- [InteractBreakPage](#T-EasyITSystemCenter-Interact-InteractBreakPage 'EasyITSystemCenter.Interact.InteractBreakPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractBreakPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractBreakPage.InitializeComponent')
- [InteractBugsPage](#T-EasyITSystemCenter-Interact-InteractBugsPage 'EasyITSystemCenter.Interact.InteractBugsPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractBugsPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractBugsPage.InitializeComponent')
- [InteractCleanWindowPage](#T-EasyITSystemCenter-Interact-InteractCleanWindowPage 'EasyITSystemCenter.Interact.InteractCleanWindowPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractCleanWindowPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractCleanWindowPage.InitializeComponent')
- [InteractMainPage](#T-EasyITSystemCenter-Interact-InteractMainPage 'EasyITSystemCenter.Interact.InteractMainPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractMainPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractMainPage.InitializeComponent')
- [InteractSettingsPage](#T-EasyITSystemCenter-Interact-InteractSettingsPage 'EasyITSystemCenter.Interact.InteractSettingsPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractSettingsPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractSettingsPage.InitializeComponent')
- [InteractUserPage](#T-EasyITSystemCenter-Interact-InteractUserPage 'EasyITSystemCenter.Interact.InteractUserPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Interact-InteractUserPage-InitializeComponent 'EasyITSystemCenter.Interact.InteractUserPage.InitializeComponent')
- [InteractUserSystemPage](#T-EasyITSystemCenter-Pages-InteractUserSystemPage 'EasyITSystemCenter.Pages.InteractUserSystemPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-InteractUserSystemPage-InitializeComponent 'EasyITSystemCenter.Pages.InteractUserSystemPage.InitializeComponent')
- [LicSrvLicenseActivationFailListPage](#T-EasyITSystemCenter-Pages-LicSrvLicenseActivationFailListPage 'EasyITSystemCenter.Pages.LicSrvLicenseActivationFailListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-LicSrvLicenseActivationFailListPage-InitializeComponent 'EasyITSystemCenter.Pages.LicSrvLicenseActivationFailListPage.InitializeComponent')
- [LicSrvLicenseAlgorithmListPage](#T-EasyITSystemCenter-Pages-LicSrvLicenseAlgorithmListPage 'EasyITSystemCenter.Pages.LicSrvLicenseAlgorithmListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-LicSrvLicenseAlgorithmListPage-InitializeComponent 'EasyITSystemCenter.Pages.LicSrvLicenseAlgorithmListPage.InitializeComponent')
- [LicSrvUsedLicenseListPage](#T-EasyITSystemCenter-Pages-LicSrvUsedLicenseListPage 'EasyITSystemCenter.Pages.LicSrvUsedLicenseListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-LicSrvUsedLicenseListPage-InitializeComponent 'EasyITSystemCenter.Pages.LicSrvUsedLicenseListPage.InitializeComponent')
- [ListBoxAutoScrollBehavior](#T-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior 'EasyITSystemCenter.GlobalStyles.ListBoxAutoScrollBehavior')
  - [GetAutoScrollToCurrentItem(obj)](#M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-GetAutoScrollToCurrentItem-System-Windows-DependencyObject- 'EasyITSystemCenter.GlobalStyles.ListBoxAutoScrollBehavior.GetAutoScrollToCurrentItem(System.Windows.DependencyObject)')
  - [OnAutoScrollToCurrentItem(listBox,index)](#M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-OnAutoScrollToCurrentItem-System-Windows-Controls-ListBox,System-Int32- 'EasyITSystemCenter.GlobalStyles.ListBoxAutoScrollBehavior.OnAutoScrollToCurrentItem(System.Windows.Controls.ListBox,System.Int32)')
  - [OnAutoScrollToCurrentItemChanged(s,e)](#M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-OnAutoScrollToCurrentItemChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'EasyITSystemCenter.GlobalStyles.ListBoxAutoScrollBehavior.OnAutoScrollToCurrentItemChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [SetAutoScrollToCurrentItem(obj,value)](#M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-SetAutoScrollToCurrentItem-System-Windows-DependencyObject,System-Boolean- 'EasyITSystemCenter.GlobalStyles.ListBoxAutoScrollBehavior.SetAutoScrollToCurrentItem(System.Windows.DependencyObject,System.Boolean)')
- [LocSrvWebTmpViewerPage](#T-EasyITSystemCenter-Pages-LocSrvWebTmpViewerPage 'EasyITSystemCenter.Pages.LocSrvWebTmpViewerPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-LocSrvWebTmpViewerPage-InitializeComponent 'EasyITSystemCenter.Pages.LocSrvWebTmpViewerPage.InitializeComponent')
- [MainWindow](#T-EasyITSystemCenter-MainWindow 'EasyITSystemCenter.MainWindow')
  - [#ctor()](#M-EasyITSystemCenter-MainWindow-#ctor 'EasyITSystemCenter.MainWindow.#ctor')
  - [lastUserAction](#F-EasyITSystemCenter-MainWindow-lastUserAction 'EasyITSystemCenter.MainWindow.lastUserAction')
  - [DataGridSelected](#P-EasyITSystemCenter-MainWindow-DataGridSelected 'EasyITSystemCenter.MainWindow.DataGridSelected')
  - [DataGridSelectedIdListIndicator](#P-EasyITSystemCenter-MainWindow-DataGridSelectedIdListIndicator 'EasyITSystemCenter.MainWindow.DataGridSelectedIdListIndicator')
  - [DgRefresh](#P-EasyITSystemCenter-MainWindow-DgRefresh 'EasyITSystemCenter.MainWindow.DgRefresh')
  - [DownloadShow](#P-EasyITSystemCenter-MainWindow-DownloadShow 'EasyITSystemCenter.MainWindow.DownloadShow')
  - [DownloadStatus](#P-EasyITSystemCenter-MainWindow-DownloadStatus 'EasyITSystemCenter.MainWindow.DownloadStatus')
  - [MultiSameTabsEnabled](#P-EasyITSystemCenter-MainWindow-MultiSameTabsEnabled 'EasyITSystemCenter.MainWindow.MultiSameTabsEnabled')
  - [OperationRunning](#P-EasyITSystemCenter-MainWindow-OperationRunning 'EasyITSystemCenter.MainWindow.OperationRunning')
  - [ProgressRing](#P-EasyITSystemCenter-MainWindow-ProgressRing 'EasyITSystemCenter.MainWindow.ProgressRing')
  - [RunReleaseMode](#P-EasyITSystemCenter-MainWindow-RunReleaseMode 'EasyITSystemCenter.MainWindow.RunReleaseMode')
  - [ServerLoggerSource](#P-EasyITSystemCenter-MainWindow-ServerLoggerSource 'EasyITSystemCenter.MainWindow.ServerLoggerSource')
  - [ServiceRunning](#P-EasyITSystemCenter-MainWindow-ServiceRunning 'EasyITSystemCenter.MainWindow.ServiceRunning')
  - [ServiceStatus](#P-EasyITSystemCenter-MainWindow-ServiceStatus 'EasyITSystemCenter.MainWindow.ServiceStatus')
  - [ShowSystemLogger](#P-EasyITSystemCenter-MainWindow-ShowSystemLogger 'EasyITSystemCenter.MainWindow.ShowSystemLogger')
  - [SystemLogger](#P-EasyITSystemCenter-MainWindow-SystemLogger 'EasyITSystemCenter.MainWindow.SystemLogger')
  - [UserLogged](#P-EasyITSystemCenter-MainWindow-UserLogged 'EasyITSystemCenter.MainWindow.UserLogged')
  - [VncRunning](#P-EasyITSystemCenter-MainWindow-VncRunning 'EasyITSystemCenter.MainWindow.VncRunning')
  - [AddOrRemoveTab(headerName,tabPage,tagText)](#M-EasyITSystemCenter-MainWindow-AddOrRemoveTab-System-String,System-Object,System-String- 'EasyITSystemCenter.MainWindow.AddOrRemoveTab(System.String,System.Object,System.String)')
  - [BtnKeyboardClick(sender,e)](#M-EasyITSystemCenter-MainWindow-BtnKeyboardClick-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.BtnKeyboardClick(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnShowLoggerClick(sender,e)](#M-EasyITSystemCenter-MainWindow-BtnShowLoggerClick-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.BtnShowLoggerClick(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_LaunchHelp_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-Btn_LaunchHelp_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Btn_LaunchHelp_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_ShowModulePanel_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-Btn_ShowModulePanel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Btn_ShowModulePanel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Btn_about_click(sender,e)](#M-EasyITSystemCenter-MainWindow-Btn_about_click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Btn_about_click(System.Object,System.Windows.RoutedEventArgs)')
  - [CbFilterDropDownClosed(sender,e)](#M-EasyITSystemCenter-MainWindow-CbFilterDropDownClosed-System-Object,System-EventArgs- 'EasyITSystemCenter.MainWindow.CbFilterDropDownClosed(System.Object,System.EventArgs)')
  - [CbPrintReportsSelected(sender,e)](#M-EasyITSystemCenter-MainWindow-CbPrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.MainWindow.CbPrintReportsSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [FilterField_SelectionChanged(sender,e)](#M-EasyITSystemCenter-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.MainWindow.FilterField_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-MainWindow-InitializeComponent 'EasyITSystemCenter.MainWindow.InitializeComponent')
  - [LoadUserMenu()](#M-EasyITSystemCenter-MainWindow-LoadUserMenu 'EasyITSystemCenter.MainWindow.LoadUserMenu')
  - [MainGrid_IsDraggingChanged(sender,e)](#M-EasyITSystemCenter-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}- 'EasyITSystemCenter.MainWindow.MainGrid_IsDraggingChanged(System.Object,System.Windows.RoutedPropertyChangedEventArgs{System.Boolean})')
  - [MainWindow_Closing(sender,e)](#M-EasyITSystemCenter-MainWindow-MainWindow_Closing-System-Object,System-ComponentModel-CancelEventArgs- 'EasyITSystemCenter.MainWindow.MainWindow_Closing(System.Object,System.ComponentModel.CancelEventArgs)')
  - [MainWindow_KeyDown(sender,e)](#M-EasyITSystemCenter-MainWindow-MainWindow_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.MainWindow.MainWindow_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [MainWindow_Loaded(sender,e)](#M-EasyITSystemCenter-MainWindow-MainWindow_Loaded-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.MainWindow_Loaded(System.Object,System.Windows.RoutedEventArgs)')
  - [Menu_action_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Menu_action_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_filter_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Mi_filter_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [Mi_logout_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-Mi_logout_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.Mi_logout_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [RemoveFilterItem_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.RemoveFilterItem_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [SetServiceStop()](#M-EasyITSystemCenter-MainWindow-SetServiceStop 'EasyITSystemCenter.MainWindow.SetServiceStop')
  - [SetSystemModuleListPanel()](#M-EasyITSystemCenter-MainWindow-SetSystemModuleListPanel 'EasyITSystemCenter.MainWindow.SetSystemModuleListPanel')
  - [ShowLoginDialog()](#M-EasyITSystemCenter-MainWindow-ShowLoginDialog 'EasyITSystemCenter.MainWindow.ShowLoginDialog')
  - [ShowMessageOnMainWindow(error,message,confirm)](#M-EasyITSystemCenter-MainWindow-ShowMessageOnMainWindow-System-Boolean,System-String,System-Boolean- 'EasyITSystemCenter.MainWindow.ShowMessageOnMainWindow(System.Boolean,System.String,System.Boolean)')
  - [StringToFilter(filterBox,advancedFilter)](#M-EasyITSystemCenter-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String- 'EasyITSystemCenter.MainWindow.StringToFilter(System.Windows.Controls.ComboBox,System.String)')
  - [SystemLoggerSourceChanged_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-SystemLoggerSourceChanged_Click-System-Object,System-EventArgs- 'EasyITSystemCenter.MainWindow.SystemLoggerSourceChanged_Click(System.Object,System.EventArgs)')
  - [SystemModulePanel_Click(sender,e)](#M-EasyITSystemCenter-MainWindow-SystemModulePanel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.MainWindow.SystemModulePanel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [SystemTimerController(sender,e)](#M-EasyITSystemCenter-MainWindow-SystemTimerController-System-Object,System-Timers-ElapsedEventArgs- 'EasyITSystemCenter.MainWindow.SystemTimerController(System.Object,System.Timers.ElapsedEventArgs)')
  - [TabPanelOnSelectionChange(sender,e)](#M-EasyITSystemCenter-MainWindow-TabPanelOnSelectionChange-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.MainWindow.TabPanelOnSelectionChange(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [TiltOpenForm(translateHeader)](#M-EasyITSystemCenter-MainWindow-TiltOpenForm-System-String- 'EasyITSystemCenter.MainWindow.TiltOpenForm(System.String)')
- [MediaOperations](#T-EasyITSystemCenter-GlobalOperations-MediaOperations 'EasyITSystemCenter.GlobalOperations.MediaOperations')
  - [ArrayToImage(array)](#M-EasyITSystemCenter-GlobalOperations-MediaOperations-ArrayToImage-System-Byte[]- 'EasyITSystemCenter.GlobalOperations.MediaOperations.ArrayToImage(System.Byte[])')
  - [CreateImageFile(file,frame,fileType)](#M-EasyITSystemCenter-GlobalOperations-MediaOperations-CreateImageFile-System-IO-FileStream,System-Windows-Media-Imaging-BitmapFrame,System-String- 'EasyITSystemCenter.GlobalOperations.MediaOperations.CreateImageFile(System.IO.FileStream,System.Windows.Media.Imaging.BitmapFrame,System.String)')
  - [GetImageImmediatelly(path)](#M-EasyITSystemCenter-GlobalOperations-MediaOperations-GetImageImmediatelly-System-String- 'EasyITSystemCenter.GlobalOperations.MediaOperations.GetImageImmediatelly(System.String)')
  - [SaveAppScreenShot(MainWindow,returnArrayOnly)](#M-EasyITSystemCenter-GlobalOperations-MediaOperations-SaveAppScreenShot-EasyITSystemCenter-MainWindow,System-Boolean- 'EasyITSystemCenter.GlobalOperations.MediaOperations.SaveAppScreenShot(EasyITSystemCenter.MainWindow,System.Boolean)')
- [MenuItem](#T-EasyITSystemCenter-Interact-Model-MenuItem 'EasyITSystemCenter.Interact.Model.MenuItem')
  - [NavigationDestinationProperty](#F-EasyITSystemCenter-Interact-Model-MenuItem-NavigationDestinationProperty 'EasyITSystemCenter.Interact.Model.MenuItem.NavigationDestinationProperty')
  - [NavigationTypeProperty](#F-EasyITSystemCenter-Interact-Model-MenuItem-NavigationTypeProperty 'EasyITSystemCenter.Interact.Model.MenuItem.NavigationTypeProperty')
- [MergedStylesExtension](#T-EasyITSystemCenter-GlobalStyles-MergedStylesExtension 'EasyITSystemCenter.GlobalStyles.MergedStylesExtension')
- [MltEicSrvWebAppPage](#T-EasyITSystemCenter-Pages-MltEicSrvWebAppPage 'EasyITSystemCenter.Pages.MltEicSrvWebAppPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-MltEicSrvWebAppPage-InitializeComponent 'EasyITSystemCenter.Pages.MltEicSrvWebAppPage.InitializeComponent')
- [MltTblGenEsbSrvFormPage](#T-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage 'EasyITSystemCenter.Pages.MltTblGenEsbSrvFormPage')
  - [GetGenericTableData()](#M-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage-GetGenericTableData 'EasyITSystemCenter.Pages.MltTblGenEsbSrvFormPage.GetGenericTableData')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage-InitializeComponent 'EasyITSystemCenter.Pages.MltTblGenEsbSrvFormPage.InitializeComponent')
- [MyCompletionData](#T-EasyITSystemCenter-Tools-MyCompletionData 'EasyITSystemCenter.Tools.MyCompletionData')
- [OWinApiMiddleWare](#T-EasyITSystemCenter-SystemHelper-OWinApiMiddleWare 'EasyITSystemCenter.SystemHelper.OWinApiMiddleWare')
- [ProdGuidGroupListPage](#T-EasyITSystemCenter-Pages-ProdGuidGroupListPage 'EasyITSystemCenter.Pages.ProdGuidGroupListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ProdGuidGroupListPage-InitializeComponent 'EasyITSystemCenter.Pages.ProdGuidGroupListPage.InitializeComponent')
- [ProdGuidOperationListPage](#T-EasyITSystemCenter-Pages-ProdGuidOperationListPage 'EasyITSystemCenter.Pages.ProdGuidOperationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ProdGuidOperationListPage-InitializeComponent 'EasyITSystemCenter.Pages.ProdGuidOperationListPage.InitializeComponent')
- [ProdGuidPartListPage](#T-EasyITSystemCenter-Pages-ProdGuidPartListPage 'EasyITSystemCenter.Pages.ProdGuidPartListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ProdGuidPartListPage-InitializeComponent 'EasyITSystemCenter.Pages.ProdGuidPartListPage.InitializeComponent')
- [ProdGuidPersonListPage](#T-EasyITSystemCenter-Pages-ProdGuidPersonListPage 'EasyITSystemCenter.Pages.ProdGuidPersonListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ProdGuidPersonListPage-InitializeComponent 'EasyITSystemCenter.Pages.ProdGuidPersonListPage.InitializeComponent')
- [ProdGuidWorkListPage](#T-EasyITSystemCenter-Pages-ProdGuidWorkListPage 'EasyITSystemCenter.Pages.ProdGuidWorkListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ProdGuidWorkListPage-InitializeComponent 'EasyITSystemCenter.Pages.ProdGuidWorkListPage.InitializeComponent')
- [ProgramaticStyles](#T-EasyITSystemCenter-GlobalStyles-ProgramaticStyles 'EasyITSystemCenter.GlobalStyles.ProgramaticStyles')
  - [GridTextRightAligment()](#M-EasyITSystemCenter-GlobalStyles-ProgramaticStyles-GridTextRightAligment 'EasyITSystemCenter.GlobalStyles.ProgramaticStyles.GridTextRightAligment')
- [ProgrammaticOperations](#T-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations 'EasyITSystemCenter.GlobalOperations.ProgrammaticOperations')
  - [ConvertStringTypeValueToSpecTypeByKnownTypeName()](#M-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations-ConvertStringTypeValueToSpecTypeByKnownTypeName-System-String,System-String- 'EasyITSystemCenter.GlobalOperations.ProgrammaticOperations.ConvertStringTypeValueToSpecTypeByKnownTypeName(System.String,System.String)')
  - [DetectTypeValueFromObject(typeString,value)](#M-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations-DetectTypeValueFromObject-System-Object- 'EasyITSystemCenter.GlobalOperations.ProgrammaticOperations.DetectTypeValueFromObject(System.Object)')
- [Resources](#T-EasyITSystemCenter-Properties-Resources 'EasyITSystemCenter.Properties.Resources')
  - [Culture](#P-EasyITSystemCenter-Properties-Resources-Culture 'EasyITSystemCenter.Properties.Resources.Culture')
  - [ResourceManager](#P-EasyITSystemCenter-Properties-Resources-ResourceManager 'EasyITSystemCenter.Properties.Resources.ResourceManager')
- [ScreenSaverPage](#T-EasyITSystemCenter-Pages-ScreenSaverPage 'EasyITSystemCenter.Pages.ScreenSaverPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ScreenSaverPage-InitializeComponent 'EasyITSystemCenter.Pages.ScreenSaverPage.InitializeComponent')
- [ServerApiSecurityListPage](#T-EasyITSystemCenter-Pages-ServerApiSecurityListPage 'EasyITSystemCenter.Pages.ServerApiSecurityListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerApiSecurityListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerApiSecurityListPage.InitializeComponent')
- [ServerCorsDefAllowedOriginListPage](#T-EasyITSystemCenter-Pages-ServerCorsDefAllowedOriginListPage 'EasyITSystemCenter.Pages.ServerCorsDefAllowedOriginListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerCorsDefAllowedOriginListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerCorsDefAllowedOriginListPage.InitializeComponent')
- [ServerHealthCheckTaskListPage](#T-EasyITSystemCenter-Pages-ServerHealthCheckTaskListPage 'EasyITSystemCenter.Pages.ServerHealthCheckTaskListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerHealthCheckTaskListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerHealthCheckTaskListPage.InitializeComponent')
- [ServerLiveDataMonitorListPage](#T-EasyITSystemCenter-Pages-ServerLiveDataMonitorListPage 'EasyITSystemCenter.Pages.ServerLiveDataMonitorListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerLiveDataMonitorListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerLiveDataMonitorListPage.InitializeComponent')
- [ServerModuleAndServiceListPage](#T-EasyITSystemCenter-Pages-ServerModuleAndServiceListPage 'EasyITSystemCenter.Pages.ServerModuleAndServiceListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerModuleAndServiceListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerModuleAndServiceListPage.InitializeComponent')
- [ServerStaticOrMvcDefPathListPage](#T-EasyITSystemCenter-Pages-ServerStaticOrMvcDefPathListPage 'EasyITSystemCenter.Pages.ServerStaticOrMvcDefPathListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerStaticOrMvcDefPathListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerStaticOrMvcDefPathListPage.InitializeComponent')
- [ServerToolPanelDefinitionListPage](#T-EasyITSystemCenter-Pages-ServerToolPanelDefinitionListPage 'EasyITSystemCenter.Pages.ServerToolPanelDefinitionListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerToolPanelDefinitionListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerToolPanelDefinitionListPage.InitializeComponent')
- [ServerToolPanelListPage](#T-EasyITSystemCenter-Pages-ServerToolPanelListPage 'EasyITSystemCenter.Pages.ServerToolPanelListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerToolPanelListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerToolPanelListPage.InitializeComponent')
- [ServerToolTypeListPage](#T-EasyITSystemCenter-Pages-ServerToolTypeListPage 'EasyITSystemCenter.Pages.ServerToolTypeListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-ServerToolTypeListPage-InitializeComponent 'EasyITSystemCenter.Pages.ServerToolTypeListPage.InitializeComponent')
- [SolutionEmailTemplateListPage](#T-EasyITSystemCenter-Pages-SolutionEmailTemplateListPage 'EasyITSystemCenter.Pages.SolutionEmailTemplateListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionEmailTemplateListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionEmailTemplateListPage.InitializeComponent')
- [SolutionEmailerHistoryListPage](#T-EasyITSystemCenter-Pages-SolutionEmailerHistoryListPage 'EasyITSystemCenter.Pages.SolutionEmailerHistoryListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionEmailerHistoryListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionEmailerHistoryListPage.InitializeComponent')
- [SolutionFailListPage](#T-EasyITSystemCenter-Pages-SolutionFailListPage 'EasyITSystemCenter.Pages.SolutionFailListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionFailListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionFailListPage.InitializeComponent')
- [SolutionLanguageListPage](#T-EasyITSystemCenter-Pages-SolutionLanguageListPage 'EasyITSystemCenter.Pages.SolutionLanguageListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionLanguageListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionLanguageListPage.InitializeComponent')
- [SolutionMessageModuleListPage](#T-EasyITSystemCenter-Pages-SolutionMessageModuleListPage 'EasyITSystemCenter.Pages.SolutionMessageModuleListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionMessageModuleListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionMessageModuleListPage.InitializeComponent')
- [SolutionMessageTypeListPage](#T-EasyITSystemCenter-Pages-SolutionMessageTypeListPage 'EasyITSystemCenter.Pages.SolutionMessageTypeListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionMessageTypeListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionMessageTypeListPage.InitializeComponent')
- [SolutionMixedEnumListPage](#T-EasyITSystemCenter-Pages-SolutionMixedEnumListPage 'EasyITSystemCenter.Pages.SolutionMixedEnumListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionMixedEnumListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionMixedEnumListPage.InitializeComponent')
- [SolutionMottoListPage](#T-EasyITSystemCenter-Pages-SolutionMottoListPage 'EasyITSystemCenter.Pages.SolutionMottoListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionMottoListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionMottoListPage.InitializeComponent')
- [SolutionOperationListPage](#T-EasyITSystemCenter-Pages-SolutionOperationListPage 'EasyITSystemCenter.Pages.SolutionOperationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionOperationListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionOperationListPage.InitializeComponent')
- [SolutionSchedulerListPage](#T-EasyITSystemCenter-Pages-SolutionSchedulerListPage 'EasyITSystemCenter.Pages.SolutionSchedulerListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionSchedulerListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionSchedulerListPage.InitializeComponent')
- [SolutionStaticFileListPage](#T-EasyITSystemCenter-Pages-SolutionStaticFileListPage 'EasyITSystemCenter.Pages.SolutionStaticFileListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionStaticFileListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionStaticFileListPage.InitializeComponent')
- [SolutionTaskListPage](#T-EasyITSystemCenter-Pages-SolutionTaskListPage 'EasyITSystemCenter.Pages.SolutionTaskListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionTaskListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionTaskListPage.InitializeComponent')
- [SolutionUserListPage](#T-EasyITSystemCenter-Pages-SolutionUserListPage 'EasyITSystemCenter.Pages.SolutionUserListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionUserListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionUserListPage.InitializeComponent')
- [SolutionUserRoleListPage](#T-EasyITSystemCenter-Pages-SolutionUserRoleListPage 'EasyITSystemCenter.Pages.SolutionUserRoleListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionUserRoleListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionUserRoleListPage.InitializeComponent')
- [SolutionWebsiteListPage](#T-EasyITSystemCenter-Pages-SolutionWebsiteListPage 'EasyITSystemCenter.Pages.SolutionWebsiteListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SolutionWebsiteListPage-InitializeComponent 'EasyITSystemCenter.Pages.SolutionWebsiteListPage.InitializeComponent')
- [Startup](#T-EasyITSystemCenter-Startup 'EasyITSystemCenter.Startup')
- [SupportPage](#T-EasyITSystemCenter-Pages-SupportPage 'EasyITSystemCenter.Pages.SupportPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SupportPage-InitializeComponent 'EasyITSystemCenter.Pages.SupportPage.InitializeComponent')
- [SystemCustomPageListPage](#T-EasyITSystemCenter-Pages-SystemCustomPageListPage 'EasyITSystemCenter.Pages.SystemCustomPageListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemCustomPageListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemCustomPageListPage.InitializeComponent')
- [SystemDocumentAdviceListPage](#T-EasyITSystemCenter-Pages-SystemDocumentAdviceListPage 'EasyITSystemCenter.Pages.SystemDocumentAdviceListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemDocumentAdviceListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemDocumentAdviceListPage.InitializeComponent')
- [SystemGroupMenuListPage](#T-EasyITSystemCenter-Pages-SystemGroupMenuListPage 'EasyITSystemCenter.Pages.SystemGroupMenuListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemGroupMenuListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemGroupMenuListPage.InitializeComponent')
- [SystemIgnoredExceptionListPage](#T-EasyITSystemCenter-Pages-SystemIgnoredExceptionListPage 'EasyITSystemCenter.Pages.SystemIgnoredExceptionListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemIgnoredExceptionListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemIgnoredExceptionListPage.InitializeComponent')
- [SystemLocalEnumSets](#T-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets 'EasyITSystemCenter.GlobalClasses.SystemLocalEnumSets')
  - [ConfigTypes](#F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-ConfigTypes 'EasyITSystemCenter.GlobalClasses.SystemLocalEnumSets.ConfigTypes')
  - [Languages](#F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-Languages 'EasyITSystemCenter.GlobalClasses.SystemLocalEnumSets.Languages')
  - [UpdateVariants](#F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-UpdateVariants 'EasyITSystemCenter.GlobalClasses.SystemLocalEnumSets.UpdateVariants')
- [SystemLoggerWebSocketClass](#T-EasyITSystemCenter-SystemHelper-SystemLoggerWebSocketClass 'EasyITSystemCenter.SystemHelper.SystemLoggerWebSocketClass')
- [SystemLoginHistoryListPage](#T-EasyITSystemCenter-Pages-SystemLoginHistoryListPage 'EasyITSystemCenter.Pages.SystemLoginHistoryListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemLoginHistoryListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemLoginHistoryListPage.InitializeComponent')
- [SystemMenuListPage](#T-EasyITSystemCenter-Pages-SystemMenuListPage 'EasyITSystemCenter.Pages.SystemMenuListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemMenuListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemMenuListPage.InitializeComponent')
- [SystemModuleListPage](#T-EasyITSystemCenter-Pages-SystemModuleListPage 'EasyITSystemCenter.Pages.SystemModuleListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemModuleListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemModuleListPage.InitializeComponent')
- [SystemMonitorPage](#T-EasyITSystemCenter-Pages-SystemMonitorPage 'EasyITSystemCenter.Pages.SystemMonitorPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemMonitorPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemMonitorPage.InitializeComponent')
- [SystemOperationListPage](#T-EasyITSystemCenter-Pages-SystemOperationListPage 'EasyITSystemCenter.Pages.SystemOperationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemOperationListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemOperationListPage.InitializeComponent')
- [SystemOperations](#T-EasyITSystemCenter-GlobalOperations-SystemOperations 'EasyITSystemCenter.GlobalOperations.SystemOperations')
  - [FilterToString(filterBox)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-FilterToString-System-Windows-Controls-ComboBox- 'EasyITSystemCenter.GlobalOperations.SystemOperations.FilterToString(System.Windows.Controls.ComboBox)')
  - [FirstLetterToLower(str)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-FirstLetterToLower-System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.FirstLetterToLower(System.String)')
  - [GetExceptionMessages(exception,msgCount)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetExceptionMessages-System-Exception,System-Int32- 'EasyITSystemCenter.GlobalOperations.SystemOperations.GetExceptionMessages(System.Exception,System.Int32)')
  - [GetExceptionMessagesAll(exception,msgCount)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetExceptionMessagesAll-System-Exception,System-Int32- 'EasyITSystemCenter.GlobalOperations.SystemOperations.GetExceptionMessagesAll(System.Exception,System.Int32)')
  - [GetLanguageCode(languageDefault)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetLanguageCode-System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.GetLanguageCode(System.String)')
  - [GetSystemLocalhostFreePort()](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetSystemLocalhostFreePort 'EasyITSystemCenter.GlobalOperations.SystemOperations.GetSystemLocalhostFreePort')
  - [IncreaseFileVersionBuild()](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-IncreaseFileVersionBuild 'EasyITSystemCenter.GlobalOperations.SystemOperations.IncreaseFileVersionBuild')
  - [PortInUse(port)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-PortInUse-System-Int32- 'EasyITSystemCenter.GlobalOperations.SystemOperations.PortInUse(System.Int32)')
  - [RandomString(length)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-RandomString-System-Int32- 'EasyITSystemCenter.GlobalOperations.SystemOperations.RandomString(System.Int32)')
  - [RemoveAppNamespaceFromString(stringForRemoveNamespace)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-RemoveAppNamespaceFromString-System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.RemoveAppNamespaceFromString(System.String)')
  - [SendMailWithMailTo(address,subject,body,attach)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-SendMailWithMailTo-System-String,System-String,System-String,System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.SendMailWithMailTo(System.String,System.String,System.String,System.String)')
  - [SendMailWithServerSetting(message)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-SendMailWithServerSetting-System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.SendMailWithServerSetting(System.String)')
  - [SetLanguageDictionary(Resources,languageDefault)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-SetLanguageDictionary-System-Windows-ResourceDictionary,System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.SetLanguageDictionary(System.Windows.ResourceDictionary,System.String)')
  - [StartExternalProccess(type,processCommand,startupPath,arguments)](#M-EasyITSystemCenter-GlobalOperations-SystemOperations-StartExternalProccess-System-String,System-String,System-String,System-String- 'EasyITSystemCenter.GlobalOperations.SystemOperations.StartExternalProccess(System.String,System.String,System.String,System.String)')
- [SystemParameterListPage](#T-EasyITSystemCenter-Pages-SystemParameterListPage 'EasyITSystemCenter.Pages.SystemParameterListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemParameterListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemParameterListPage.InitializeComponent')
- [SystemReportListPage](#T-EasyITSystemCenter-Pages-SystemReportListPage 'EasyITSystemCenter.Pages.SystemReportListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemReportListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemReportListPage.InitializeComponent')
- [SystemReportQueueListPage](#T-EasyITSystemCenter-Pages-SystemReportQueueListPage 'EasyITSystemCenter.Pages.SystemReportQueueListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemReportQueueListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemReportQueueListPage.InitializeComponent')
- [SystemStatuses](#T-EasyITSystemCenter-GlobalClasses-SystemStatuses 'EasyITSystemCenter.GlobalClasses.SystemStatuses')
- [SystemSvgIconListPage](#T-EasyITSystemCenter-Pages-SystemSvgIconListPage 'EasyITSystemCenter.Pages.SystemSvgIconListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemSvgIconListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemSvgIconListPage.InitializeComponent')
- [SystemTranslatedTableList](#T-EasyITSystemCenter-GlobalClasses-SystemTranslatedTableList 'EasyITSystemCenter.GlobalClasses.SystemTranslatedTableList')
- [SystemTranslationListPage](#T-EasyITSystemCenter-Pages-SystemTranslationListPage 'EasyITSystemCenter.Pages.SystemTranslationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-SystemTranslationListPage-InitializeComponent 'EasyITSystemCenter.Pages.SystemTranslationListPage.InitializeComponent')
- [SystemWindowDataModel](#T-EasyITSystemCenter-SystemStructure-SystemWindowDataModel 'EasyITSystemCenter.SystemStructure.SystemWindowDataModel')
  - [#ctor()](#M-EasyITSystemCenter-SystemStructure-SystemWindowDataModel-#ctor 'EasyITSystemCenter.SystemStructure.SystemWindowDataModel.#ctor')
- [TabItemPage](#T-EasyITSystemCenter-Pages-TabItemPage 'EasyITSystemCenter.Pages.TabItemPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TabItemPage-InitializeComponent 'EasyITSystemCenter.Pages.TabItemPage.InitializeComponent')
- [TemplateClassListAutoDBTranslationPage](#T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationPage 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationPage.InitializeComponent')
- [TemplateClassListAutoDBTranslationViewPage](#T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationViewPage 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationViewPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationViewPage.InitializeComponent')
- [TemplateClassListAutoDBTranslationWithParentPage](#T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithParentPage 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithParentPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithParentPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithParentPage.InitializeComponent')
- [TemplateClassListAutoDBTranslationWithSubPage](#T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-#ctor 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.dataViewSupport')
  - [BtnCancel_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.BtnCancel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnItemDelete_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnItemDelete_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.BtnItemDelete_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnItemInsert_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnItemInsert_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.BtnItemInsert_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnSave_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.BtnSave_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [ClearItemsFields()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-ClearItemsFields 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.ClearItemsFields')
  - [Customer_KeyDown(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.Customer_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [DeleteRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DeleteRecord 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.DgListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-EditRecord-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-Filter-System-String- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.Filter(System.String)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.InitializeComponent')
  - [LoadDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-LoadDataList 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.LoadDataList')
  - [NewRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-NewRecord 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.NewRecord')
  - [NotesChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.NotesChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [PartNumberGotFocus(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.PartNumberGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [PartNumber_KeyDown(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.PartNumber_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectCustomer_Enter(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SelectCustomer_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectGotFocus(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SelectGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [SelectPartNumber_Enter(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SelectPartNumber_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SetCustomer()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetCustomer 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SetCustomer')
  - [SetPartNumber()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetPartNumber 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SetPartNumber')
  - [SetRecord(showForm,copy)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetRecord-System-Nullable{System-Boolean},System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SetRecord(System.Nullable{System.Boolean},System.Boolean)')
  - [SetSubListsNonActiveOnNewItem()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.SetSubListsNonActiveOnNewItem(System.Boolean)')
  - [UpdateCustomerSearchResults()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-UpdateCustomerSearchResults 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.UpdateCustomerSearchResults')
  - [UpdatePartNumberSearchResults()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-UpdatePartNumberSearchResults 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.UpdatePartNumberSearchResults')
  - [dgSubListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-dgSubListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubPage.dgSubListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
- [TemplateClassListAutoDBTranslationWithSubViewPage](#T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-#ctor 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.dataViewSupport')
  - [BtnCancel_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.BtnCancel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnSave_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.BtnSave_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [DeleteRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DeleteRecord 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.DgListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-EditRecord-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-Filter-System-String- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.Filter(System.String)')
  - [Fixed_Checked(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-Fixed_Checked-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.Fixed_Checked(System.Object,System.Windows.RoutedEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.InitializeComponent')
  - [LoadDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-LoadDataList 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.LoadDataList')
  - [LoadSubDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-LoadSubDataList 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.LoadSubDataList')
  - [NewRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-NewRecord 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.NewRecord')
  - [SetRecord(showForm,copy)](#M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-SetRecord-System-Nullable{System-Boolean},System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListAutoDBTranslationWithSubViewPage.SetRecord(System.Nullable{System.Boolean},System.Boolean)')
- [TemplateClassListPage](#T-EasyITSystemCenter-Pages-TemplateClassListPage 'EasyITSystemCenter.Pages.TemplateClassListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListPage.InitializeComponent')
- [TemplateClassListViewPage](#T-EasyITSystemCenter-Pages-TemplateClassListViewPage 'EasyITSystemCenter.Pages.TemplateClassListViewPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListViewPage.InitializeComponent')
- [TemplateClassListWithParentPage](#T-EasyITSystemCenter-Pages-TemplateClassListWithParentPage 'EasyITSystemCenter.Pages.TemplateClassListWithParentPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListWithParentPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListWithParentPage.InitializeComponent')
- [TemplateClassListWithSubPage](#T-EasyITSystemCenter-Pages-TemplateClassListWithSubPage 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-#ctor 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.dataViewSupport')
  - [BtnCancel_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.BtnCancel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnItemDelete_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnItemDelete_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.BtnItemDelete_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnItemInsert_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnItemInsert_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.BtnItemInsert_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnSave_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.BtnSave_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [ClearItemsFields()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-ClearItemsFields 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.ClearItemsFields')
  - [Customer_KeyDown(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.Customer_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [DeleteRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DeleteRecord 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.DgListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-EditRecord-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-Filter-System-String- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.Filter(System.String)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.InitializeComponent')
  - [LoadDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-LoadDataList 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.LoadDataList')
  - [NewRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-NewRecord 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.NewRecord')
  - [NotesChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.NotesChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [PartNumberGotFocus(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.PartNumberGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [PartNumber_KeyDown(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.PartNumber_KeyDown(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectCustomer_Enter(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SelectCustomer_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SelectGotFocus(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SelectGotFocus(System.Object,System.Windows.RoutedEventArgs)')
  - [SelectPartNumber_Enter(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SelectPartNumber_Enter(System.Object,System.Windows.Input.KeyEventArgs)')
  - [SetCustomer()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetCustomer 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SetCustomer')
  - [SetPartNumber()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetPartNumber 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SetPartNumber')
  - [SetRecord(showForm,copy)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetRecord-System-Nullable{System-Boolean},System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SetRecord(System.Nullable{System.Boolean},System.Boolean)')
  - [SetSubListsNonActiveOnNewItem()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.SetSubListsNonActiveOnNewItem(System.Boolean)')
  - [UpdateCustomerSearchResults()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-UpdateCustomerSearchResults 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.UpdateCustomerSearchResults')
  - [UpdatePartNumberSearchResults()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-UpdatePartNumberSearchResults 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.UpdatePartNumberSearchResults')
  - [dgSubListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-dgSubListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubPage.dgSubListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
- [TemplateClassListWithSubViewPage](#T-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-#ctor 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.dataViewSupport')
  - [BtnCancel_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.BtnCancel_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [BtnSave_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.BtnSave_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [DeleteRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DeleteRecord 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.DeleteRecord')
  - [DgListView_MouseDoubleClick(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.DgListView_MouseDoubleClick(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [DgListView_SelectionChanged(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.DgListView_SelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [DgListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.DgListView_Translate(System.Object,System.EventArgs)')
  - [DgSubListView_Translate(sender,ex)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.DgSubListView_Translate(System.Object,System.EventArgs)')
  - [EditRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-EditRecord-System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.EditRecord(System.Boolean)')
  - [Filter(filter)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-Filter-System-String- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.Filter(System.String)')
  - [Fixed_Checked(sender,e)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-Fixed_Checked-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.Fixed_Checked(System.Object,System.Windows.RoutedEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.InitializeComponent')
  - [LoadDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-LoadDataList 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.LoadDataList')
  - [LoadSubDataList()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-LoadSubDataList 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.LoadSubDataList')
  - [NewRecord()](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-NewRecord 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.NewRecord')
  - [SetRecord(showForm,copy)](#M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-SetRecord-System-Nullable{System-Boolean},System-Boolean- 'EasyITSystemCenter.Pages.TemplateClassListWithSubViewPage.SetRecord(System.Nullable{System.Boolean},System.Boolean)')
- [TemplateDocumentViewPage](#T-EasyITSystemCenter-Pages-TemplateDocumentViewPage 'EasyITSystemCenter.Pages.TemplateDocumentViewPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateDocumentViewPage-#ctor 'EasyITSystemCenter.Pages.TemplateDocumentViewPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateDocumentViewPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateDocumentViewPage.dataViewSupport')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateDocumentViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateDocumentViewPage.InitializeComponent')
- [TemplateSTLPage](#T-EasyITSystemCenter-Pages-TemplateSTLPage 'EasyITSystemCenter.Pages.TemplateSTLPage')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateSTLPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateSTLPage.dataViewSupport')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateSTLPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateSTLPage.InitializeComponent')
- [TemplateSettingsPage](#T-EasyITSystemCenter-Pages-TemplateSettingsPage 'EasyITSystemCenter.Pages.TemplateSettingsPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateSettingsPage-#ctor 'EasyITSystemCenter.Pages.TemplateSettingsPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateSettingsPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateSettingsPage.dataViewSupport')
  - [BtnApiTest_Click(sender,e)](#M-EasyITSystemCenter-Pages-TemplateSettingsPage-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.TemplateSettingsPage.BtnApiTest_Click(System.Object,System.Windows.RoutedEventArgs)')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateSettingsPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateSettingsPage.InitializeComponent')
- [TemplateVideoPage](#T-EasyITSystemCenter-Pages-TemplateVideoPage 'EasyITSystemCenter.Pages.TemplateVideoPage')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateVideoPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateVideoPage.dataViewSupport')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateVideoPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateVideoPage.InitializeComponent')
- [TemplateWebViewPage](#T-EasyITSystemCenter-Pages-TemplateWebViewPage 'EasyITSystemCenter.Pages.TemplateWebViewPage')
  - [#ctor()](#M-EasyITSystemCenter-Pages-TemplateWebViewPage-#ctor 'EasyITSystemCenter.Pages.TemplateWebViewPage.#ctor')
  - [dataViewSupport](#F-EasyITSystemCenter-Pages-TemplateWebViewPage-dataViewSupport 'EasyITSystemCenter.Pages.TemplateWebViewPage.dataViewSupport')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-TemplateWebViewPage-InitializeComponent 'EasyITSystemCenter.Pages.TemplateWebViewPage.InitializeComponent')
- [TextBoxBehavior](#T-EasyITSystemCenter-GlobalStyles-TextBoxBehavior 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior')
  - [SelectAllTextOnFocusProperty](#F-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SelectAllTextOnFocusProperty 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.SelectAllTextOnFocusProperty')
  - [GetSelectAllTextOnFocus(textBox)](#M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-GetSelectAllTextOnFocus-System-Windows-Controls-TextBox- 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.GetSelectAllTextOnFocus(System.Windows.Controls.TextBox)')
  - [IgnoreMouseButton(sender,e)](#M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-IgnoreMouseButton-System-Object,System-Windows-Input-MouseButtonEventArgs- 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.IgnoreMouseButton(System.Object,System.Windows.Input.MouseButtonEventArgs)')
  - [OnSelectAllTextOnFocusChanged(d,e)](#M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-OnSelectAllTextOnFocusChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs- 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.OnSelectAllTextOnFocusChanged(System.Windows.DependencyObject,System.Windows.DependencyPropertyChangedEventArgs)')
  - [SelectAll(sender,e)](#M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SelectAll-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.SelectAll(System.Object,System.Windows.RoutedEventArgs)')
  - [SetSelectAllTextOnFocus(textBox,value)](#M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SetSelectAllTextOnFocus-System-Windows-Controls-TextBox,System-Boolean- 'EasyITSystemCenter.GlobalStyles.TextBoxBehavior.SetSelectAllTextOnFocus(System.Windows.Controls.TextBox,System.Boolean)')
- [TextMarkerService](#T-EasyITSystemCenter-Tools-TextMarkerService 'EasyITSystemCenter.Tools.TextMarkerService')
  - [Redraw()](#M-EasyITSystemCenter-Tools-TextMarkerService-Redraw-ICSharpCode-AvalonEdit-Document-ISegment- 'EasyITSystemCenter.Tools.TextMarkerService.Redraw(ICSharpCode.AvalonEdit.Document.ISegment)')
- [TextMarkerTypes](#T-EasyITSystemCenter-Tools-TextMarkerTypes 'EasyITSystemCenter.Tools.TextMarkerTypes')
  - [CircleInScrollBar](#F-EasyITSystemCenter-Tools-TextMarkerTypes-CircleInScrollBar 'EasyITSystemCenter.Tools.TextMarkerTypes.CircleInScrollBar')
  - [DottedUnderline](#F-EasyITSystemCenter-Tools-TextMarkerTypes-DottedUnderline 'EasyITSystemCenter.Tools.TextMarkerTypes.DottedUnderline')
  - [LineInScrollBar](#F-EasyITSystemCenter-Tools-TextMarkerTypes-LineInScrollBar 'EasyITSystemCenter.Tools.TextMarkerTypes.LineInScrollBar')
  - [None](#F-EasyITSystemCenter-Tools-TextMarkerTypes-None 'EasyITSystemCenter.Tools.TextMarkerTypes.None')
  - [NormalUnderline](#F-EasyITSystemCenter-Tools-TextMarkerTypes-NormalUnderline 'EasyITSystemCenter.Tools.TextMarkerTypes.NormalUnderline')
  - [ScrollBarLeftTriangle](#F-EasyITSystemCenter-Tools-TextMarkerTypes-ScrollBarLeftTriangle 'EasyITSystemCenter.Tools.TextMarkerTypes.ScrollBarLeftTriangle')
  - [ScrollBarRightTriangle](#F-EasyITSystemCenter-Tools-TextMarkerTypes-ScrollBarRightTriangle 'EasyITSystemCenter.Tools.TextMarkerTypes.ScrollBarRightTriangle')
  - [SquigglyUnderline](#F-EasyITSystemCenter-Tools-TextMarkerTypes-SquigglyUnderline 'EasyITSystemCenter.Tools.TextMarkerTypes.SquigglyUnderline')
- [TiltTargets](#T-EasyITSystemCenter-GlobalClasses-TiltTargets 'EasyITSystemCenter.GlobalClasses.TiltTargets')
- [ToolsOperations](#T-EasyITSystemCenter-ToolsOperations 'EasyITSystemCenter.ToolsOperations')
  - [AvalonEditorFindText(searchQuery,foundedIndex,textEditor,ignoreCaseSensitive)](#M-EasyITSystemCenter-ToolsOperations-AvalonEditorFindText-System-String,System-Int32@,ICSharpCode-AvalonEdit-TextEditor@,System-Boolean- 'EasyITSystemCenter.ToolsOperations.AvalonEditorFindText(System.String,System.Int32@,ICSharpCode.AvalonEdit.TextEditor@,System.Boolean)')
  - [AvalonEditorReplaceText(sourceString,targetString,foundedIndex,textEditor,ignoreCaseSensitive,selectedonly)](#M-EasyITSystemCenter-ToolsOperations-AvalonEditorReplaceText-System-String,System-String,System-Int32@,ICSharpCode-AvalonEdit-TextEditor@,System-Boolean,System-Boolean- 'EasyITSystemCenter.ToolsOperations.AvalonEditorReplaceText(System.String,System.String,System.Int32@,ICSharpCode.AvalonEdit.TextEditor@,System.Boolean,System.Boolean)')
- [TranslateSet](#T-EasyITSystemCenter-GlobalClasses-TranslateSet 'EasyITSystemCenter.GlobalClasses.TranslateSet')
- [TranslationSet](#T-EasyITSystemCenter-GlobalClasses-TranslationSet 'EasyITSystemCenter.GlobalClasses.TranslationSet')
- [TriggerTypes](#T-EasyITSystemCenter-GlobalStyles-TriggerTypes 'EasyITSystemCenter.GlobalStyles.TriggerTypes')
- [UniversalCodeEditorPage](#T-EasyITSystemCenter-Pages-UniversalCodeEditorPage 'EasyITSystemCenter.Pages.UniversalCodeEditorPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-InitializeComponent 'EasyITSystemCenter.Pages.UniversalCodeEditorPage.InitializeComponent')
  - [TemplateSelected(sender,e)](#M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.UniversalCodeEditorPage.TemplateSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [btnTheme_Click(sender,e)](#M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.UniversalCodeEditorPage.btnTheme_Click(System.Object,System.Windows.RoutedEventArgs)')
- [UrlSourceTypes](#T-EasyITSystemCenter-GlobalClasses-UrlSourceTypes 'EasyITSystemCenter.GlobalClasses.UrlSourceTypes')
- [UserData](#T-EasyITSystemCenter-GlobalClasses-UserData 'EasyITSystemCenter.GlobalClasses.UserData')
- [UserFileStorage](#T-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage 'EasyITSystemCenter.GlobalOperations.FileOperations.UserFileStorage')
  - [SaveFile(fileList)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage-SaveFile-System-Tuple{System-String,System-String}- 'EasyITSystemCenter.GlobalOperations.FileOperations.UserFileStorage.SaveFile(System.Tuple{System.String,System.String})')
  - [SaveFilesAsync(fileList)](#M-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage-SaveFilesAsync-System-Collections-Generic-List{System-Tuple{System-String,System-String}}- 'EasyITSystemCenter.GlobalOperations.FileOperations.UserFileStorage.SaveFilesAsync(System.Collections.Generic.List{System.Tuple{System.String,System.String}})')
- [WebBannedIpAddressListPage](#T-EasyITSystemCenter-Pages-WebBannedIpAddressListPage 'EasyITSystemCenter.Pages.WebBannedIpAddressListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebBannedIpAddressListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebBannedIpAddressListPage.InitializeComponent')
- [WebCodeEditorPage](#T-EasyITSystemCenter-Pages-WebCodeEditorPage 'EasyITSystemCenter.Pages.WebCodeEditorPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebCodeEditorPage-InitializeComponent 'EasyITSystemCenter.Pages.WebCodeEditorPage.InitializeComponent')
- [WebCodeLibraryListPage](#T-EasyITSystemCenter-Pages-WebCodeLibraryListPage 'EasyITSystemCenter.Pages.WebCodeLibraryListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebCodeLibraryListPage.InitializeComponent')
  - [TemplateSelected(sender,e)](#M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.WebCodeLibraryListPage.TemplateSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [btnTheme_Click(sender,e)](#M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.WebCodeLibraryListPage.btnTheme_Click(System.Object,System.Windows.RoutedEventArgs)')
- [WebConfiguratorListPage](#T-EasyITSystemCenter-Pages-WebConfiguratorListPage 'EasyITSystemCenter.Pages.WebConfiguratorListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebConfiguratorListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebConfiguratorListPage.InitializeComponent')
  - [TemplateSelected(sender,e)](#M-EasyITSystemCenter-Pages-WebConfiguratorListPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs- 'EasyITSystemCenter.Pages.WebConfiguratorListPage.TemplateSelected(System.Object,System.Windows.Controls.SelectionChangedEventArgs)')
  - [btnTheme_Click(sender,e)](#M-EasyITSystemCenter-Pages-WebConfiguratorListPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs- 'EasyITSystemCenter.Pages.WebConfiguratorListPage.btnTheme_Click(System.Object,System.Windows.RoutedEventArgs)')
- [WebCoreFileListPage](#T-EasyITSystemCenter-Pages-WebCoreFileListPage 'EasyITSystemCenter.Pages.WebCoreFileListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebCoreFileListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebCoreFileListPage.InitializeComponent')
- [WebDeveloperNewsListPage](#T-EasyITSystemCenter-Pages-WebDeveloperNewsListPage 'EasyITSystemCenter.Pages.WebDeveloperNewsListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebDeveloperNewsListPage.InitializeComponent')
  - [JSGetDataFromBrowser()](#M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-JSGetDataFromBrowser 'EasyITSystemCenter.Pages.WebDeveloperNewsListPage.JSGetDataFromBrowser')
  - [JSSetDataFromBrowser(inputHtml,isNewRequest)](#M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-JSSetDataFromBrowser-System-String,System-Boolean- 'EasyITSystemCenter.Pages.WebDeveloperNewsListPage.JSSetDataFromBrowser(System.String,System.Boolean)')
- [WebDocumentationCodeLibraryListPage](#T-EasyITSystemCenter-Pages-WebDocumentationCodeLibraryListPage 'EasyITSystemCenter.Pages.WebDocumentationCodeLibraryListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebDocumentationCodeLibraryListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebDocumentationCodeLibraryListPage.InitializeComponent')
- [WebDocumentationListPage](#T-EasyITSystemCenter-Pages-WebDocumentationListPage 'EasyITSystemCenter.Pages.WebDocumentationListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebDocumentationListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebDocumentationListPage.InitializeComponent')
- [WebGlobalPageBlockListPage](#T-EasyITSystemCenter-Pages-WebGlobalPageBlockListPage 'EasyITSystemCenter.Pages.WebGlobalPageBlockListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebGlobalPageBlockListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebGlobalPageBlockListPage.InitializeComponent')
- [WebGroupMenuListPage](#T-EasyITSystemCenter-Pages-WebGroupMenuListPage 'EasyITSystemCenter.Pages.WebGroupMenuListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebGroupMenuListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebGroupMenuListPage.InitializeComponent')
- [WebMenuListPage](#T-EasyITSystemCenter-Pages-WebMenuListPage 'EasyITSystemCenter.Pages.WebMenuListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebMenuListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebMenuListPage.InitializeComponent')
  - [JSGetDataFromBrowser()](#M-EasyITSystemCenter-Pages-WebMenuListPage-JSGetDataFromBrowser 'EasyITSystemCenter.Pages.WebMenuListPage.JSGetDataFromBrowser')
  - [JSSetDataFromBrowser(inputHtml,isNewRequest)](#M-EasyITSystemCenter-Pages-WebMenuListPage-JSSetDataFromBrowser-System-String,System-Boolean- 'EasyITSystemCenter.Pages.WebMenuListPage.JSSetDataFromBrowser(System.String,System.Boolean)')
- [WebSettingListPage](#T-EasyITSystemCenter-Pages-WebSettingListPage 'EasyITSystemCenter.Pages.WebSettingListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebSettingListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebSettingListPage.InitializeComponent')
- [WebView2AutoInstaller](#T-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller 'EasyITSystemCenter.SystemHelper.WebView2AutoInstaller')
  - [CheckAndInstallWebView()](#M-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller-CheckAndInstallWebView 'EasyITSystemCenter.SystemHelper.WebView2AutoInstaller.CheckAndInstallWebView')
  - [InstallWebView()](#M-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller-InstallWebView 'EasyITSystemCenter.SystemHelper.WebView2AutoInstaller.InstallWebView')
- [WebVisitIpListPage](#T-EasyITSystemCenter-Pages-WebVisitIpListPage 'EasyITSystemCenter.Pages.WebVisitIpListPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WebVisitIpListPage-InitializeComponent 'EasyITSystemCenter.Pages.WebVisitIpListPage.InitializeComponent')
- [WelcomePage](#T-EasyITSystemCenter-Pages-WelcomePage 'EasyITSystemCenter.Pages.WelcomePage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-WelcomePage-InitializeComponent 'EasyITSystemCenter.Pages.WelcomePage.InitializeComponent')
- [XamlCodeEditorPage](#T-EasyITSystemCenter-Pages-XamlCodeEditorPage 'EasyITSystemCenter.Pages.XamlCodeEditorPage')
  - [InitializeComponent()](#M-EasyITSystemCenter-Pages-XamlCodeEditorPage-InitializeComponent 'EasyITSystemCenter.Pages.XamlCodeEditorPage.InitializeComponent')
- [XamlFormGenerators](#T-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators 'EasyITSystemCenter.GlobalGenerators.XamlFormGenerators')
  - [StandardXamlFormGenerator(rootGrid,dataset,systemCustomPageList)](#M-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators-StandardXamlFormGenerator-System-Windows-Controls-Grid,System-Data-DataTable,EasyITSystemCenter-GlobalClasses-SystemCustomPageList- 'EasyITSystemCenter.GlobalGenerators.XamlFormGenerators.StandardXamlFormGenerator(System.Windows.Controls.Grid,System.Data.DataTable,EasyITSystemCenter.GlobalClasses.SystemCustomPageList)')
  - [StandardXamlFormIODataController(userForm,selectedRecord,recordForSave,dataToForm,systemCustomPageSetting,newRec,copy)](#M-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators-StandardXamlFormIODataController-System-Windows-Controls-Grid@,System-Data-DataRowView@,System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}@,System-Boolean,EasyITSystemCenter-GlobalClasses-SystemCustomPageList,System-Boolean,System-Boolean- 'EasyITSystemCenter.GlobalGenerators.XamlFormGenerators.StandardXamlFormIODataController(System.Windows.Controls.Grid@,System.Data.DataRowView@,System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}@,System.Boolean,EasyITSystemCenter.GlobalClasses.SystemCustomPageList,System.Boolean,System.Boolean)')

<a name='T-EasyITSystemCenter-GlobalStyles-AnimationLibrary'></a>
## AnimationLibrary `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

Library of Defined Effect Types

<a name='T-EasyITSystemCenter-Api-ApiUrls'></a>
## ApiUrls `type`

##### Namespace

EasyITSystemCenter.Api

##### Summary

ALL standard View AND Form API Call must end with "List" - These will automatic added for
reports Definitions TODO From Table?

<a name='T-EasyITSystemCenter-App'></a>
## App `type`

##### Namespace

EasyITSystemCenter

##### Summary

App

<a name='M-EasyITSystemCenter-App-#ctor'></a>
### #ctor() `constructor`

##### Summary

Application Global Exceptions Controls Definitions

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-App-TiltReceiptDoc'></a>
### TiltReceiptDoc `constants`

##### Summary

Tilt Document types definitions

<a name='F-EasyITSystemCenter-App-appRuntimeData'></a>
### appRuntimeData `constants`

##### Summary

Global Application Startup Settings Central Parameters / Languages / User / Configure
TODO must centralize to Global APP class

<a name='F-EasyITSystemCenter-App-log'></a>
### log `constants`

##### Summary

System Core Needs Runtime Data For Working
//TODO move to RuntimeData

<a name='M-EasyITSystemCenter-App-AppQuitRequest-System-Boolean-'></a>
### AppQuitRequest(silent) `method`

##### Summary

System or Quit

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| silent | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITSystemCenter-App-AppRestart'></a>
### AppRestart() `method`

##### Summary

System Restart Controller

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-App-ApplicationLogging-System-Exception,System-String-'></a>
### ApplicationLogging(ex,customMessage) `method`

##### Summary

Full Application System logging Running If is AppSystemTimer is Enabled for disable
other processes exceptions Full Application logging to file if enabled and to DB for
solving by Developers Supported Custom Message Here Is Filling Local System Logger for
Developers Logging to Database Are All non Developer working

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| ex | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| customMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-App-ApplicationQuit'></a>
### ApplicationQuit() `method`

##### Summary

MainWindow Closing Handler for Cleaning TempData, disable AddOns / Tool and Third Party
Software Closing Third Party processes

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-App-CurrentDomain_FirstChanceException-System-Object,System-Runtime-ExceptionServices-FirstChanceExceptionEventArgs-'></a>
### CurrentDomain_FirstChanceException(sender,e) `method`

##### Summary

FullSystem Logging Every Exception types are monitored for maximize correct running all
processes, System addOns, systems, communications, threads, network All detail of
application system add all used possibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs 'System.Runtime.ExceptionServices.FirstChanceExceptionEventArgs') |  |

<a name='M-EasyITSystemCenter-App-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-App-Main'></a>
### Main() `method`

##### Summary

Application Entry Point.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-App-OnStartup-System-Windows-StartupEventArgs-'></a>
### OnStartup(e) `method`

##### Summary

Connected Starting Video

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.StartupEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.StartupEventArgs 'System.Windows.StartupEventArgs') |  |

<a name='M-EasyITSystemCenter-App-RootAppKeyDownController-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### RootAppKeyDownController(sender,e) `method`

##### Summary

Keyboard Pointer to Central Keyboard Reaction Definitions

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-App-StartupLocaslWebServer'></a>
### StartupLocaslWebServer() `method`

##### Summary

Local Web Server Controller

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-AppRuntimeData'></a>
## AppRuntimeData `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

!!!SYSTEM Global Runtime Monitor Definition For One Point monitoring For Processes and each
 other Definition For optimize the System Running

 TODO
 - move All Central Definitions Here
 - create Monitor Window for managing

<a name='F-EasyITSystemCenter-GlobalClasses-AppRuntimeData-JsonSerializeOptions'></a>
### JsonSerializeOptions `constants`

##### Summary

JSON Predefined

<a name='T-EasyITSystemCenter-GlobalClasses-AppVersion'></a>
## AppVersion `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Program version Class

<a name='T-EasyITSystemCenter-GlobalClasses-AuthentificationResponse'></a>
## AuthentificationResponse `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Class for User Authentication information

<a name='T-EasyITSystemCenter-Pages-BasicAttachmentListPage'></a>
## BasicAttachmentListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicAttachmentListPage

<a name='M-EasyITSystemCenter-Pages-BasicAttachmentListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BasicCalendarListPage'></a>
## BasicCalendarListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicCalendarListPage

<a name='M-EasyITSystemCenter-Pages-BasicCalendarListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BasicCurrencyListPage'></a>
## BasicCurrencyListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicCurrencyListPage

<a name='M-EasyITSystemCenter-Pages-BasicCurrencyListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BasicImageGalleryListPage'></a>
## BasicImageGalleryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicImageGalleryListPage

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-ClearGallery'></a>
### ClearGallery() `method`

##### Summary

Phycical clear local storage and form

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-GrayscaleClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### GrayscaleClick(sender,e) `method`

##### Summary

Images Effect Part

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-ImageChangesCancelClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### ImageChangesCancelClick(sender,e) `method`

##### Summary

Image Graphics Changes Controllers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-LoadFromServer-System-Int32-'></a>
### LoadFromServer() `method`

##### Summary

Last proccess

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-RefreshViewPhoto-System-Nullable{System-Int32}-'></a>
### RefreshViewPhoto(selectedPhotoId) `method`

##### Summary



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| selectedPhotoId | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') | selectedPhotoId -1 is Select Last |

<a name='M-EasyITSystemCenter-Pages-BasicImageGalleryListPage-SaveImageToServer-System-Nullable{System-Int32}-'></a>
### SaveImageToServer(onlyThis) `method`

##### Summary

null For Full Folder else No of dbId, 0 = new

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onlyThis | [System.Nullable{System.Int32}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Int32}') |  |

<a name='T-EasyITSystemCenter-Pages-BasicItemListPage'></a>
## BasicItemListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicItemListPage

<a name='M-EasyITSystemCenter-Pages-BasicItemListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BasicUnitListPage'></a>
## BasicUnitListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicUnitListPage

<a name='M-EasyITSystemCenter-Pages-BasicUnitListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BasicVatListPage'></a>
## BasicVatListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BasicVatListPage

<a name='M-EasyITSystemCenter-Pages-BasicVatListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-BindableBase'></a>
## BindableBase `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

Implementation of [INotifyPropertyChanged](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.INotifyPropertyChanged 'System.ComponentModel.INotifyPropertyChanged') to simplify models.

<a name='M-EasyITSystemCenter-Interact-BindableBase-OnPropertyChanged-System-String-'></a>
### OnPropertyChanged(propertyName) `method`

##### Summary

Notifies listeners that a property value has changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the property used to notify listeners.  This
value is optional and can be provided automatically when invoked from compilers
that support [CallerMemberNameAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.CompilerServices.CallerMemberNameAttribute 'System.Runtime.CompilerServices.CallerMemberNameAttribute'). |

<a name='M-EasyITSystemCenter-Interact-BindableBase-SetProperty``1-``0@,``0,System-String-'></a>
### SetProperty\`\`1(storage,value,propertyName) `method`

##### Summary

Checks if a property already matches a desired value.  Sets the property and
notifies listeners only when necessary.

##### Returns

True if the value was changed, false if the existing value matched the
desired value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| storage | [\`\`0@](#T-``0@ '``0@') | Reference to a property with both getter and setter. |
| value | [\`\`0](#T-``0 '``0') | Desired value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the property used to notify listeners.  This
value is optional and can be provided automatically when invoked from compilers that
support CallerMemberName. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the property. |

<a name='T-EasyITSystemCenter-Tools-BraceFoldingStrategy'></a>
## BraceFoldingStrategy `type`

##### Namespace

EasyITSystemCenter.Tools

##### Summary

Allows producing foldings from a document based on braces.

<a name='M-EasyITSystemCenter-Tools-BraceFoldingStrategy-#ctor'></a>
### #ctor() `constructor`

##### Summary

Creates a new BraceFoldingStrategy.

##### Parameters

This constructor has no parameters.

<a name='P-EasyITSystemCenter-Tools-BraceFoldingStrategy-ClosingBrace'></a>
### ClosingBrace `property`

##### Summary

Gets/Sets the closing brace. The default value is '}'.

<a name='P-EasyITSystemCenter-Tools-BraceFoldingStrategy-OpeningBrace'></a>
### OpeningBrace `property`

##### Summary

Gets/Sets the opening brace. The default value is '{'.

<a name='M-EasyITSystemCenter-Tools-BraceFoldingStrategy-CreateNewFoldings-ICSharpCode-AvalonEdit-Document-TextDocument,System-Int32@-'></a>
### CreateNewFoldings() `method`

##### Summary

Create [NewFolding](#T-ICSharpCode-AvalonEdit-Folding-NewFolding 'ICSharpCode.AvalonEdit.Folding.NewFolding')s for the specified document.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Tools-BraceFoldingStrategy-CreateNewFoldings-ICSharpCode-AvalonEdit-Document-ITextSource-'></a>
### CreateNewFoldings() `method`

##### Summary

Create [NewFolding](#T-ICSharpCode-AvalonEdit-Folding-NewFolding 'ICSharpCode.AvalonEdit.Folding.NewFolding')s for the specified document.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessAddressListPage'></a>
## BusinessAddressListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessAddressListPage

<a name='M-EasyITSystemCenter-Pages-BusinessAddressListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessBranchListPage'></a>
## BusinessBranchListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessBranchListPage

<a name='M-EasyITSystemCenter-Pages-BusinessBranchListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessCreditNoteListPage'></a>
## BusinessCreditNoteListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessCreditNoteListPage

<a name='M-EasyITSystemCenter-Pages-BusinessCreditNoteListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessExchangeRateListPage'></a>
## BusinessExchangeRateListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessExchangeRateListPage

<a name='M-EasyITSystemCenter-Pages-BusinessExchangeRateListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessIncomingInvoiceListPage'></a>
## BusinessIncomingInvoiceListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessIncomingInvoiceListPage

<a name='M-EasyITSystemCenter-Pages-BusinessIncomingInvoiceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessIncomingOrderListPage'></a>
## BusinessIncomingOrderListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessIncomingOrderListPage

<a name='M-EasyITSystemCenter-Pages-BusinessIncomingOrderListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessMaturityListPage'></a>
## BusinessMaturityListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessMaturityListPage

<a name='M-EasyITSystemCenter-Pages-BusinessMaturityListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessNotesListPage'></a>
## BusinessNotesListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessNotesListPage

<a name='M-EasyITSystemCenter-Pages-BusinessNotesListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessOfferListPage'></a>
## BusinessOfferListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessOfferListPage

<a name='M-EasyITSystemCenter-Pages-BusinessOfferListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessOutgoingInvoiceListPage'></a>
## BusinessOutgoingInvoiceListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessOutgoingInvoiceListPage

<a name='M-EasyITSystemCenter-Pages-BusinessOutgoingInvoiceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessOutgoingOrderListPage'></a>
## BusinessOutgoingOrderListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessOutgoingOrderListPage

<a name='M-EasyITSystemCenter-Pages-BusinessOutgoingOrderListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessPaymentMethodListPage'></a>
## BusinessPaymentMethodListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessPaymentMethodListPage

<a name='M-EasyITSystemCenter-Pages-BusinessPaymentMethodListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessPaymentStatusListPage'></a>
## BusinessPaymentStatusListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessPaymentStatusListPage

<a name='M-EasyITSystemCenter-Pages-BusinessPaymentStatusListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessReceiptListPage'></a>
## BusinessReceiptListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessReceiptListPage

<a name='M-EasyITSystemCenter-Pages-BusinessReceiptListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-BusinessWarehouseListPage'></a>
## BusinessWarehouseListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

BusinessWarehouseListPage

<a name='M-EasyITSystemCenter-Pages-BusinessWarehouseListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ClientSettingsPage'></a>
## ClientSettingsPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

!!! REMEMBER EACH NEW CONFIGURATION MUST BE INSERTED TO DICTIONARY MANUALLY !!!
!!! THIS IS ALONE OFFLINE FORM WHICH READ DICTIONARY FROM APP RESOURCES !!!

<a name='M-EasyITSystemCenter-Pages-ClientSettingsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Tools-ColorizeAvalonEdit'></a>
## ColorizeAvalonEdit `type`

##### Namespace

EasyITSystemCenter.Tools

##### Summary

Finds the word 'AvalonEdit' and makes it bold and italic.

<a name='T-EasyITSystemCenter-GlobalOperations-CommOperations'></a>
## CommOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

##### Summary

Centralized Communication Operations as Console, Web Socket 
Plugins and Extensions communications

<a name='T-EasyITSystemCenter-Api-CommunicationManager'></a>
## CommunicationManager `type`

##### Namespace

EasyITSystemCenter.Api

##### Summary

Centralizes Api Comminucation
TODO: Add Socket Communication

<a name='M-EasyITSystemCenter-Api-CommunicationManager-ApiManagerGetRequest-EasyITSystemCenter-GlobalClasses-UrlSourceTypes,System-String,System-String-'></a>
### ApiManagerGetRequest(UrlPrefix,UrlOrSubPath,UrlPathExtension) `method`

##### Summary

Centralised Definition For Use Direct Different GET Requests
for Check, Simple Html Download, API messages, etc..
Implemented Automatic Correction, Formates, Login,Logging
TODO: COPY It To Server For NEW ADENDA AUTOMATED API PROCESSES + Scheduling
TODO: Nev Agenda Saved Auth Connections
TODO: Pupetier Downloader
TODO: Same Solution For WebSocket

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| UrlPrefix | [EasyITSystemCenter.GlobalClasses.UrlSourceTypes](#T-EasyITSystemCenter-GlobalClasses-UrlSourceTypes 'EasyITSystemCenter.GlobalClasses.UrlSourceTypes') |  |
| UrlOrSubPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| UrlPathExtension | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-Api-CommunicationManager-ApiManagerPostRequest``1-EasyITSystemCenter-GlobalClasses-UrlSourceTypes,System-String,System-Net-Http-HttpContent,System-String-'></a>
### ApiManagerPostRequest\`\`1(UrlPrefix,UrlOrSubPath,htmlContent,UrlPathExtension) `method`

##### Summary

Centralised Definition For Use Direct Different POST Requests
for Check, Simple Html Download, API messages, etc..
Implemented Automatic Correction, Formates, Login,Logging
TODO: COPY It To Server For NEW ADENDA AUTOMATED API PROCESSES + Scheduling
TODO: Nev Agenda Saved Auth Connections
TODO: Pupetier Downloader
TODO: Same Solution For WebSocket
USE NEWTONSOFT ONLY

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| UrlPrefix | [EasyITSystemCenter.GlobalClasses.UrlSourceTypes](#T-EasyITSystemCenter-GlobalClasses-UrlSourceTypes 'EasyITSystemCenter.GlobalClasses.UrlSourceTypes') |  |
| UrlOrSubPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| htmlContent | [System.Net.Http.HttpContent](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpContent 'System.Net.Http.HttpContent') |  |
| UrlPathExtension | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-EasyITSystemCenter-SystemConfiguration-CrashReporterSettings'></a>
## CrashReporterSettings `type`

##### Namespace

EasyITSystemCenter.SystemConfiguration

##### Summary

Libreria condivisa

<a name='F-EasyITSystemCenter-SystemConfiguration-CrashReporterSettings-_ReportCrash'></a>
### _ReportCrash `constants`

##### Summary

FirstRun

<a name='T-EasyITSystemCenter-GlobalClasses-CustomMessageList'></a>
## CustomMessageList `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Custom Definition for Returning List with One Record from Operation Stored Procedures

<a name='T-EasyITSystemCenter-GlobalOperations-DBOperations'></a>
## DBOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

##### Summary

Centralised DBFunctions as Load DB Congig, System Dials (Language, Params) Another Db
functions As Saving System Loging, Language Dictionary Autofiling

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-DBTranslation-System-String,System-Boolean,System-Boolean,System-String-'></a>
### DBTranslation(systemName,notCreateNew,comaList,lang) `method`

##### Summary

Centralised Method for Translating by DB Dictionary Service insert the news words for
translate (After translate request) to Database Automaticaly with Empty Translate.
Service return translate if is possible or requested word send back CamelCase ignored
Default Language: CZ

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| systemName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| notCreateNew | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| comaList | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| lang | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadInheritedDataList-System-String-'></a>
### LoadInheritedDataList(groupName) `method`

##### Summary

Global Inherited Load Function
Loads the inherited data list By ColumnName
Its must be InheritedGroupName 
'Inherited' is removed and GroupName Is Loaded

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| groupName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The group name. |

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadOrRefreshUserData'></a>
### LoadOrRefreshUserData() `method`

##### Summary

Centralised Method for Refresh All UserData params, for correct App running. Thinking
for remove and new Load Actualy limited by DebugingHelpSetting Itr user After Succes
User Login

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadStartupDBData'></a>
### LoadStartupDBData() `method`

##### Summary

Startup Load System Parameters ,Languages, System Controlling, Server Setting

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-LoadWaitingDataInSleepMode'></a>
### LoadWaitingDataInSleepMode() `method`

##### Summary

Reload SYSTEM Dials When System Sleep For Non Blocking Work Was Problem For More Startup
Saving and Reloading with Language List

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-SaveSystemFailMessage-System-String,System-String-'></a>
### SaveSystemFailMessage(message,logLevel) `method`

##### Summary

Save Exception to DB Fail List (System Log) Write to System Logger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| logLevel | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DBOperations-SetNonUserDataOnSuccessStartUp'></a>
### SetNonUserDataOnSuccessStartUp() `method`

##### Summary

SYSTEM: Set NonUser Startup Data for Correct Prepare System Its for All Status Possible
- NODB,OS,IS,Network,etc. For check ANY possible problems out of System

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-DBResult'></a>
## DBResult `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Database response types definition

<a name='T-EasyITSystemCenter-Api-DBResultMessage'></a>
## DBResultMessage `type`

##### Namespace

EasyITSystemCenter.Api

##### Summary

Global API Definition of Result API calls for All Calling of Insert / Update / Delete

<a name='T-EasyITSystemCenter-GlobalOperations-DataOperations'></a>
## DataOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

##### Summary

Centralized DataOperations as Cleaning dataset Language Dictionary Auto filing

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertDataTableToXml-System-Data-DataTable,System-String-'></a>
### ConvertDataTableToXml(dataTable,tablename) `method`

##### Summary

Converts the data table to xml.

##### Returns

A XElement.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataTable | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The data table. |
| tablename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The tablename. |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertDictionaryListToJson-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### ConvertDictionaryListToJson(keyList) `method`

##### Summary

Convert Dictionary string,string To Json Suportted Values Bool, Int, String

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| keyList | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertGenericClassListToStandard``1-``0-'></a>
### ConvertGenericClassListToStandard\`\`1(data) `method`

##### Summary

Convert Generic Tabla To Standard Table For Use Standard System Fields

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertGenericClassToStandard``1-``0-'></a>
### ConvertGenericClassToStandard\`\`1(data) `method`

##### Summary

Convert Generic Tabla To Standard Table For Use Standard System Fields

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| data | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ConvertTableToClassListByType-System-Data-DataTable,System-Type-'></a>
### ConvertTableToClassListByType(dt,classType) `method`

##### Summary

Convert Data Table To DataList of Type

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') |  |
| classType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-GenericConvertTableToClassList``1-System-Data-DataTable-'></a>
### GenericConvertTableToClassList\`\`1(dt) `method`

##### Summary

Generic Convert Data Table To DataList

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The dt. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-GenericToEnum``1-System-String-'></a>
### GenericToEnum\`\`1(value) `method`

##### Summary

Convert String to Generic Enum

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-IgnoreCaseReplaceString-System-String,System-String,System-String-'></a>
### IgnoreCaseReplaceString(originalValue,replaceFrom,ReplaceTo) `method`

##### Summary

Ignores the case replace string.

##### Returns

A string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| originalValue | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The original value. |
| replaceFrom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The replace from. |
| ReplaceTo | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The replace to. |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-NullSetInExtensionFields``1-``0@-'></a>
### NullSetInExtensionFields\`\`1() `method`

##### Summary

!!! SYSTEM RULE: ClassList with joining fields names must be nullable before API
operation !!! ClassName must contain: "Extended" WORD Extension field in Class - Dataset
must be set as null before Database Operation else is joining to other dataset is valid
and can be blocked by fail key Its Check Extended in ClassName - SYSTEM RULE

##### Returns



##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ObjectToJson-System-Object-'></a>
### ObjectToJson(obj) `method`

##### Summary

Object To Json Serializer

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-ParameterCheck-System-String-'></a>
### ParameterCheck(parameterName) `method`

##### Summary

Return Requested User or if not exist default DB parameter CamelCase Ignored

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameterName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-RemoveDiacritism-System-String-'></a>
### RemoveDiacritism(Text) `method`

##### Summary

Remove Diactritics

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-StringToByteArray-System-String-'></a>
### StringToByteArray(input) `method`

##### Summary

Convert String To ByteArray

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| input | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-DataOperations-Utf8toUnicode-System-String-'></a>
### Utf8toUnicode(utf8String) `method`

##### Summary

Convert UTF8 to UNICODE

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utf8String | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITSystemCenter-DataResources'></a>
## DataResources `type`

##### Namespace

EasyITSystemCenter

<a name='M-EasyITSystemCenter-DataResources-GetImageResource-System-String-'></a>
### GetImageResource(resourceFile) `method`

##### Summary

Get Uri from Images From Data/Images Folder
Requested parameter is Filename

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceFile | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-DataResources-GetMediaResource-System-String-'></a>
### GetMediaResource(resourceFile) `method`

##### Summary

Get Uri from Files From Data/Media Folder
Requested parameter is Filename

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| resourceFile | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITSystemCenter-GlobalClasses-DataViewSupport'></a>
## DataViewSupport `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Actual List Item informations for Controls each Page in MainView

<a name='T-EasyITSystemCenter-Interact-DelegateCommand'></a>
## DelegateCommand `type`

##### Namespace

EasyITSystemCenter.Interact

<a name='M-EasyITSystemCenter-Interact-DelegateCommand-#ctor-System-Action-'></a>
### #ctor(execute) `constructor`

##### Summary

Initializes a new instance of the RelayCommand class that 
can always execute.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The execution logic. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If the execute argument is null. |

<a name='M-EasyITSystemCenter-Interact-DelegateCommand-#ctor-System-Action,System-Func{System-Boolean}-'></a>
### #ctor(execute,canExecute) `constructor`

##### Summary

Initializes a new instance of the RelayCommand class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The execution logic. |
| canExecute | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The execution status logic. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If the execute argument is null. |

<a name='M-EasyITSystemCenter-Interact-DelegateCommand-CanExecute-System-Object-'></a>
### CanExecute(parameter) `method`

##### Summary

Defines the method that determines whether the command can execute in its current state.

##### Returns

true if this command can be executed; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | This parameter will always be ignored. |

<a name='M-EasyITSystemCenter-Interact-DelegateCommand-Execute-System-Object-'></a>
### Execute(parameter) `method`

##### Summary

Defines the method to be called when the command is invoked.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | This parameter will always be ignored. |

<a name='M-EasyITSystemCenter-Interact-DelegateCommand-RaiseCanExecuteChanged'></a>
### RaiseCanExecuteChanged() `method`

##### Summary

Raises the [](#E-EasyITSystemCenter-Interact-DelegateCommand-CanExecuteChanged 'EasyITSystemCenter.Interact.DelegateCommand.CanExecuteChanged') event.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-DeserializedJson'></a>
## DeserializedJson `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Custom Definition for Returning List with One Record from Operation Stored Procedures

<a name='T-EasyITSystemCenter-Pages-DocSrvDocTemplateListPage'></a>
## DocSrvDocTemplateListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

DocSrvDocTemplateListPage

<a name='M-EasyITSystemCenter-Pages-DocSrvDocTemplateListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-DocSrvDocumentationCodeLibraryListPage'></a>
## DocSrvDocumentationCodeLibraryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

DocSrvDocumentationCodeLibraryListPage

<a name='M-EasyITSystemCenter-Pages-DocSrvDocumentationCodeLibraryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-DocSrvDocumentationGroupListPage'></a>
## DocSrvDocumentationGroupListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

DocSrvDocumentationGroupListPage

<a name='M-EasyITSystemCenter-Pages-DocSrvDocumentationGroupListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-DocSrvDocumentationListPage'></a>
## DocSrvDocumentationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

DocSrvDocumentationListPage

<a name='M-EasyITSystemCenter-Pages-DocSrvDocumentationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-DocumentItemList'></a>
## DocumentItemList `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Univesal Document List (Item) for Offer,Order,Invoice

<a name='T-EasyITSystemCenter-GlobalStyles-EffectLibrary'></a>
## EffectLibrary `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

Programmatic StoryBoard Effect Library For Dynamic Using
On Generated Objects Without XAML Definitions \

More Animations Examples
https://learn.microsoft.com/en-us/dotnet/desktop/wpf/graphics-multimedia/how-to-make-an-element-spin-in-place?view=netframeworkdesktop-4.8
https://github.com/XamlFlair/XamlFlair?tab=readme-ov-file#debugging-animations

<a name='M-EasyITSystemCenter-GlobalStyles-EffectLibrary-GetAnimationEffect-System-Windows-FrameworkElement,EasyITSystemCenter-GlobalStyles-AnimationLibrary,EasyITSystemCenter-GlobalStyles-EffectTypes,EasyITSystemCenter-GlobalStyles-TriggerTypes,System-Double,System-Int32-'></a>
### GetAnimationEffect() `method`

##### Summary

Programatic Defined StoryBoardEffect Library For All UIElements
for Multiple Using With Direct Join On Setted Object 
Using Example:

double iconSize = 120;
Image icon = new Image() { Width = iconSize, Height = iconSize, Source = spinner, VerticalAlignment = VerticalAlignment.Stretch, HorizontalAlignment = HorizontalAlignment.Stretch };
Get StoryBoard Type From Animation Library
icon = (Image) EffectLibrary.GetAnimationEffect(icon, AnimationLibrary.RotationAndSizeEffect, EffectTypes.SizeNoneToWidthEffect, TriggerTypes.OnMouseMove, iconSize, 2);

Rotation
icon = (Image)EffectLibrary.GetAnimationEffect(icon, AnimationLibrary.RotationAndSizeEffect, EffectTypes.RotationEffect, TriggerTypes.OnMouseMove, 360, 2);

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalStyles-EffectTypes'></a>
## EffectTypes `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

Implemented StoryBoard Programmatic Types
Rotation is Rotate Effect
With is

<a name='T-EasyITSystemCenter-Pages-ExternalWebAppPage'></a>
## ExternalWebAppPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ExternalWebAppPage

<a name='M-EasyITSystemCenter-Pages-ExternalWebAppPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalOperations-FileOperations'></a>
## FileOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-ByteArrayToFile-System-String,System-Byte[]-'></a>
### ByteArrayToFile(fileName,byteArray) `method`

##### Summary

Write ByteArray to File

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |
| byteArray | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The byte array. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CheckDirectory-System-String-'></a>
### CheckDirectory(directory) `method`

##### Summary

Checks the directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CheckFile-System-String-'></a>
### CheckFile(file) `method`

##### Summary

Checks the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-ClearFolder-System-String-'></a>
### ClearFolder(FolderName) `method`

##### Summary

Full Clear Folder

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FolderName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the folder. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-ConvertSystemFilePathFromUrl-System-String-'></a>
### ConvertSystemFilePathFromUrl(webpath) `method`

##### Summary

Return Full File path to the operating system default slashes.
!!! USE as + With Path Combine Path.Combine(yourpath) + ConvertSystemFilePathFromUrl(string webpath);

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| webpath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyDirectory-System-String,System-String-'></a>
### CopyDirectory(directory) `method`

##### Summary

Copy Full directory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyFile-System-String,System-String-'></a>
### CopyFile(from,to) `method`

##### Summary

/

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| from | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | From. |
| to | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | To. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CopyFiles-System-String,System-String-'></a>
### CopyFiles(sourcePath,destinationPath) `method`

##### Summary

Prepared Method for Files Copy

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| destinationPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CreateDirectory-System-String-'></a>
### CreateDirectory(directory) `method`

##### Summary

Creates the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CreateFile-System-String-'></a>
### CreateFile(file) `method`

##### Summary

Prepared Method for Create empty file

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-CreatePath-System-String,System-Boolean-'></a>
### CreatePath(path,clearIfExist) `method`

##### Summary

Creates the path recursively.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| clearIfExist | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-DeleteDirectory-System-String-'></a>
### DeleteDirectory(directory) `method`

##### Summary

Deletes the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-DeleteFile-System-String-'></a>
### DeleteFile(file) `method`

##### Summary

Deletes the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-FileDetectEncoding-System-String-'></a>
### FileDetectEncoding(FileName) `method`

##### Summary

Prepared Method for Get Information of File encoding UTF8,WIN1250,etc

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| FileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-GetPathFiles-System-String,System-String,System-IO-SearchOption-'></a>
### GetPathFiles(sourcePath,fileMask,searchOption) `method`

##### Summary

Get Folder Files from Direct Folder
or FULL Structure by fileMask

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourcePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileMask | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| searchOption | [System.IO.SearchOption](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.SearchOption 'System.IO.SearchOption') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-LoadSettings'></a>
### LoadSettings() `method`

##### Summary

Application Startup Check and configure Data Structure in folder ProgramData And
required files, load client configuration config.json

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-ReadFile-System-String-'></a>
### ReadFile(fileName) `method`

##### Summary

Reads the file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Name of the file. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-SaveSettings'></a>
### SaveSettings() `method`

##### Summary

Function for saving Application Configuration This is client configuration only

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-UnicodeToUTF8-System-String-'></a>
### UnicodeToUTF8(strFrom) `method`

##### Summary

Unicodes to ut f8.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| strFrom | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string from. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-VncServerIniFile-System-String-'></a>
### VncServerIniFile(path) `method`

##### Summary

Generate ini file for start vns server default password: groupware

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-WriteToFile-System-String,System-String,System-Boolean-'></a>
### WriteToFile(file,content,rewrite) `method`

##### Summary

Write String to File Used for JsonSaving
If rewrite file is false, content is append

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| rewrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-GlobalOperations-FormOperations'></a>
## FormOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

##### Summary

Centralised Forms Functions for work with Types, methods, Formats, Logic, supported methods

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-AnalphabetAndNumericOnlyValidated-System-Windows-Input-TextCompositionEventArgs@,System-Boolean-'></a>
### AnalphabetAndNumericOnlyValidated() `method`

##### Summary

TextInput allowing Analphabetical and numeric character Only

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-DisplayAllToolTips_OnClick-System-Windows-FrameworkElement-'></a>
### DisplayAllToolTips_OnClick(userControl) `method`

##### Summary

Secventional Show All Tooltips On
Shown Objects in System

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userControl | [System.Windows.FrameworkElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.FrameworkElement 'System.Windows.FrameworkElement') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-FindVisualChildren``1-System-Windows-DependencyObject-'></a>
### FindVisualChildren\`\`1(depObj) `method`

##### Summary

Get All Children of Root-Parent Object by Type
Using for Global Translating, Change Properties, etc..

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| depObj | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-NumberOnlyValidated-System-String-'></a>
### NumberOnlyValidated() `method`

##### Summary

Text Input Allowing Numeric Characters Only

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-RemoveDisabledSpacesFromTextInput-System-Object@,System-Windows-Controls-TextChangedEventArgs@-'></a>
### RemoveDisabledSpacesFromTextInput() `method`

##### Summary

Removes the disabled spaces from referenced Inpout.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-TranslateFormFields-System-Windows-DependencyObject-'></a>
### TranslateFormFields(parentObject) `method`

##### Summary

Globa Translator for Objects with Defined Name as: xx_translatedString
Prepared for MenuItem, Label, Button, GroupBox, TabItems

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentObject | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-FormOperations-TranslateSubObjectsNameToToolTip``1-``0-'></a>
### TranslateSubObjectsNameToToolTip\`\`1(parentObject) `method`

##### Summary

Translate Toolbar Items Name to Tooltip Description
Buttons, CheckBox, ComboBox

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parentObject | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-EasyITSystemCenter-Interact-FrameAnimator'></a>
## FrameAnimator `type`

##### Namespace

EasyITSystemCenter.Interact

<a name='M-EasyITSystemCenter-Interact-FrameAnimator-GetFrameNavigationStoryboard-System-Windows-DependencyObject-'></a>
### GetFrameNavigationStoryboard(control) `method`

##### Summary

Helper for getting [FrameNavigationStoryboardProperty](#F-EasyITSystemCenter-Interact-FrameAnimator-FrameNavigationStoryboardProperty 'EasyITSystemCenter.Interact.FrameAnimator.FrameNavigationStoryboardProperty') from `control`.

##### Returns

FrameNavigationStoryboard property value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | [DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') to read [FrameNavigationStoryboardProperty](#F-EasyITSystemCenter-Interact-FrameAnimator-FrameNavigationStoryboardProperty 'EasyITSystemCenter.Interact.FrameAnimator.FrameNavigationStoryboardProperty') from. |

<a name='M-EasyITSystemCenter-Interact-FrameAnimator-SetFrameNavigationStoryboard-System-Windows-DependencyObject,System-Windows-Media-Animation-Storyboard-'></a>
### SetFrameNavigationStoryboard(control,storyboard) `method`

##### Summary

Helper for setting [FrameNavigationStoryboardProperty](#F-EasyITSystemCenter-Interact-FrameAnimator-FrameNavigationStoryboardProperty 'EasyITSystemCenter.Interact.FrameAnimator.FrameNavigationStoryboardProperty') on `control`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| control | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | [DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') to set [FrameNavigationStoryboardProperty](#F-EasyITSystemCenter-Interact-FrameAnimator-FrameNavigationStoryboardProperty 'EasyITSystemCenter.Interact.FrameAnimator.FrameNavigationStoryboardProperty') on. |
| storyboard | [System.Windows.Media.Animation.Storyboard](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Media.Animation.Storyboard 'System.Windows.Media.Animation.Storyboard') | FrameNavigationStoryboard property value. |

<a name='T-XamlGeneratedNamespace-GeneratedInternalTypeHelper'></a>
## GeneratedInternalTypeHelper `type`

##### Namespace

XamlGeneratedNamespace

##### Summary

GeneratedInternalTypeHelper

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-AddEventHandler-System-Reflection-EventInfo,System-Object,System-Delegate-'></a>
### AddEventHandler() `method`

##### Summary

AddEventHandler

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateDelegate-System-Type,System-Object,System-String-'></a>
### CreateDelegate() `method`

##### Summary

CreateDelegate

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-CreateInstance-System-Type,System-Globalization-CultureInfo-'></a>
### CreateInstance() `method`

##### Summary

CreateInstance

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-GetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Globalization-CultureInfo-'></a>
### GetPropertyValue() `method`

##### Summary

GetPropertyValue

##### Parameters

This method has no parameters.

<a name='M-XamlGeneratedNamespace-GeneratedInternalTypeHelper-SetPropertyValue-System-Reflection-PropertyInfo,System-Object,System-Object,System-Globalization-CultureInfo-'></a>
### SetPropertyValue() `method`

##### Summary

SetPropertyValue

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-GenericDataList'></a>
## GenericDataList `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Generická Tabulka Používaná DB Procedurami
je to Objekt ve stringu, nebo string, Cokoliv,
Jen to musí být v tabulce se sloupcem Data

<a name='T-EasyITSystemCenter-GlobalClasses-GenericTable'></a>
## GenericTable `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Generic Table Standard Fieds Public Class For Get Informations By System

<a name='T-EasyITSystemCenter-GlobalClasses-GenericValue'></a>
## GenericValue `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Custom Definition for Returning List with One Record from Operation Stored Procedures
Returrned the "Value"  as Key, Value

<a name='T-EasyITSystemCenter-Pages-GraphsPage'></a>
## GraphsPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

GraphsPage

<a name='M-EasyITSystemCenter-Pages-GraphsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalOperations-HardwareOperations'></a>
## HardwareOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

<a name='M-EasyITSystemCenter-GlobalOperations-HardwareOperations-ApplicationKeyboardMaping-System-Windows-Input-KeyEventArgs-'></a>
### ApplicationKeyboardMaping(e) `method`

##### Summary

Application Keyboard controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='T-EasyITSystemCenter-Pages-HostWin32AppPage'></a>
## HostWin32AppPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

HostWin32AppPage

<a name='F-EasyITSystemCenter-Pages-HostWin32AppPage-_appWin'></a>
### _appWin `constants`

##### Summary

Handle to the application Window

<a name='F-EasyITSystemCenter-Pages-HostWin32AppPage-_iscreated'></a>
### _iscreated `constants`

##### Summary

Track if the application has been created

<a name='F-EasyITSystemCenter-Pages-HostWin32AppPage-_isdisposed'></a>
### _isdisposed `constants`

##### Summary

Track if the control is disposed

<a name='F-EasyITSystemCenter-Pages-HostWin32AppPage-exeName'></a>
### exeName `constants`

##### Summary

The name of the exe to launch

<a name='M-EasyITSystemCenter-Pages-HostWin32AppPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-HostWin32AppPage-OnResize-System-Object,System-Windows-SizeChangedEventArgs-'></a>
### OnResize(e) `method`

##### Summary

Update display of the executable

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Not used |

<a name='M-EasyITSystemCenter-Pages-HostWin32AppPage-OnSizeChanged-System-Object,System-Windows-SizeChangedEventArgs-'></a>
### OnSizeChanged(e) `method`

##### Summary

Force redraw of control when size changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Not used |

<a name='M-EasyITSystemCenter-Pages-HostWin32AppPage-OnVisibleChanged-System-Object,System-Windows-RoutedEventArgs-'></a>
### OnVisibleChanged(e) `method`

##### Summary

Create control when visibility changes

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Not used |

<a name='T-EasyITSystemCenter-Pages-HtmlFullEditorPage'></a>
## HtmlFullEditorPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

HtmlFullEditorPage

<a name='M-EasyITSystemCenter-Pages-HtmlFullEditorPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Tools-ITextMarker'></a>
## ITextMarker `type`

##### Namespace

EasyITSystemCenter.Tools

##### Summary

Represents a text marker.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-BackgroundColor'></a>
### BackgroundColor `property`

##### Summary

Gets/Sets the background color.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-EndOffset'></a>
### EndOffset `property`

##### Summary

Gets the end offset of the marked text region.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-FontStyle'></a>
### FontStyle `property`

##### Summary

Gets/Sets the font style.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-FontWeight'></a>
### FontWeight `property`

##### Summary

Gets/Sets the font weight.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-ForegroundColor'></a>
### ForegroundColor `property`

##### Summary

Gets/Sets the foreground color.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-IsDeleted'></a>
### IsDeleted `property`

##### Summary

Gets whether the text marker was deleted.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-Length'></a>
### Length `property`

##### Summary

Gets the length of the marked region.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-MarkerColor'></a>
### MarkerColor `property`

##### Summary

Gets/Sets the color of the marker.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-MarkerTypes'></a>
### MarkerTypes `property`

##### Summary

Gets/Sets the type of the marker. Use TextMarkerType.None for normal markers.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-StartOffset'></a>
### StartOffset `property`

##### Summary

Gets the start offset of the marked text region.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-Tag'></a>
### Tag `property`

##### Summary

Gets/Sets an object with additional data for this text marker.

<a name='P-EasyITSystemCenter-Tools-ITextMarker-ToolTip'></a>
### ToolTip `property`

##### Summary

Gets/Sets an object that will be displayed as tooltip in the text editor.

##### Remarks

Not supported in this sample!

<a name='M-EasyITSystemCenter-Tools-ITextMarker-Delete'></a>
### Delete() `method`

##### Summary

Deletes the text marker.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Tools-ITextMarkerService'></a>
## ITextMarkerService `type`

##### Namespace

EasyITSystemCenter.Tools

<a name='P-EasyITSystemCenter-Tools-ITextMarkerService-TextMarkers'></a>
### TextMarkers `property`

##### Summary

Gets the list of text markers.

<a name='M-EasyITSystemCenter-Tools-ITextMarkerService-Create-System-Int32,System-Int32-'></a>
### Create() `method`

##### Summary

Creates a new text marker. The text marker will be invisible at first,
you need to set one of the Color properties to make it visible.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Tools-ITextMarkerService-GetMarkersAtOffset-System-Int32-'></a>
### GetMarkersAtOffset() `method`

##### Summary

Finds all text markers at the specified offset.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Tools-ITextMarkerService-Remove-EasyITSystemCenter-Tools-ITextMarker-'></a>
### Remove() `method`

##### Summary

Removes the specified text marker.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Tools-ITextMarkerService-RemoveAll-System-Predicate{EasyITSystemCenter-Tools-ITextMarker}-'></a>
### RemoveAll() `method`

##### Summary

Removes all text markers that match the condition.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalGenerators-IconMaker'></a>
## IconMaker `type`

##### Namespace

EasyITSystemCenter.GlobalGenerators

##### Summary

System Online Icon Generator from custom Path Its for working with Icon over Database Dynamically

<a name='M-EasyITSystemCenter-GlobalGenerators-IconMaker-Icon-System-Windows-Media-Color,System-String-'></a>
### Icon(color,iconPath) `method`

##### Summary

Generate Custom Icon from Defined Path

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| color | [System.Windows.Media.Color](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Media.Color 'System.Windows.Media.Color') | The color. |
| iconPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The icon path. |

<a name='T-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator'></a>
## ImageElementGenerator `type`

##### Namespace

EasyITSystemCenter.GlobalGenerators

##### Summary

This class can be used to embed images inside AvalonEdit like this:

<a name='M-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator-ConstructElement-System-Int32-'></a>
### ConstructElement() `method`

##### Summary

Constructs an element at the specified offset.
May return null if no element should be constructed.

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalGenerators-ImageElementGenerator-GetFirstInterestedOffset-System-Int32-'></a>
### GetFirstInterestedOffset() `method`

##### Summary

Gets the first offset >= startOffset where the generator wants to construct
an element.
Return -1 to signal no interest.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractAboutPage'></a>
## InteractAboutPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractAboutPage

<a name='M-EasyITSystemCenter-Interact-InteractAboutPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractAwesomePage'></a>
## InteractAwesomePage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractAwesomePage

<a name='M-EasyITSystemCenter-Interact-InteractAwesomePage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractBreakPage'></a>
## InteractBreakPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractBreakPage

<a name='M-EasyITSystemCenter-Interact-InteractBreakPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractBugsPage'></a>
## InteractBugsPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractBugsPage

<a name='M-EasyITSystemCenter-Interact-InteractBugsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractCleanWindowPage'></a>
## InteractCleanWindowPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

Interaction logic for CleanWindow.xaml

<a name='M-EasyITSystemCenter-Interact-InteractCleanWindowPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractMainPage'></a>
## InteractMainPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractMainPage

<a name='M-EasyITSystemCenter-Interact-InteractMainPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractSettingsPage'></a>
## InteractSettingsPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractSettingsPage

<a name='M-EasyITSystemCenter-Interact-InteractSettingsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Interact-InteractUserPage'></a>
## InteractUserPage `type`

##### Namespace

EasyITSystemCenter.Interact

##### Summary

InteractUserPage

<a name='M-EasyITSystemCenter-Interact-InteractUserPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-InteractUserSystemPage'></a>
## InteractUserSystemPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

Interaction logic for MainWindow.xaml

<a name='M-EasyITSystemCenter-Pages-InteractUserSystemPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-LicSrvLicenseActivationFailListPage'></a>
## LicSrvLicenseActivationFailListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

LicSrvLicenseActivationFailListPage

<a name='M-EasyITSystemCenter-Pages-LicSrvLicenseActivationFailListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-LicSrvLicenseAlgorithmListPage'></a>
## LicSrvLicenseAlgorithmListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

LicSrvLicenseAlgorithmListPage

<a name='M-EasyITSystemCenter-Pages-LicSrvLicenseAlgorithmListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-LicSrvUsedLicenseListPage'></a>
## LicSrvUsedLicenseListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

LicSrvUsedLicenseListPage

<a name='M-EasyITSystemCenter-Pages-LicSrvUsedLicenseListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior'></a>
## ListBoxAutoScrollBehavior `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

<a name='M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-GetAutoScrollToCurrentItem-System-Windows-DependencyObject-'></a>
### GetAutoScrollToCurrentItem(obj) `method`

##### Summary

Returns the value of the AutoScrollToCurrentItemProperty

##### Returns

The value of the given property

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The dependency-object whichs value should be returned |

<a name='M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-OnAutoScrollToCurrentItem-System-Windows-Controls-ListBox,System-Int32-'></a>
### OnAutoScrollToCurrentItem(listBox,index) `method`

##### Summary

This method will be called when the ListBox should
be scrolled to the given index

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| listBox | [System.Windows.Controls.ListBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ListBox 'System.Windows.Controls.ListBox') | The ListBox which should be scrolled |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index of the item to which it should be scrolled |

<a name='M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-OnAutoScrollToCurrentItemChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnAutoScrollToCurrentItemChanged(s,e) `method`

##### Summary

This method will be called when the AutoScrollToCurrentItem
property was changed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The sender (the ListBox) |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | Some additional information |

<a name='M-EasyITSystemCenter-GlobalStyles-ListBoxAutoScrollBehavior-SetAutoScrollToCurrentItem-System-Windows-DependencyObject,System-Boolean-'></a>
### SetAutoScrollToCurrentItem(obj,value) `method`

##### Summary

Sets the value of the AutoScrollToCurrentItemProperty

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The dependency-object whichs value should be set |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | The value which should be assigned to the AutoScrollToCurrentItemProperty |

<a name='T-EasyITSystemCenter-Pages-LocSrvWebTmpViewerPage'></a>
## LocSrvWebTmpViewerPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

//Local Web Server Web Template App Viewer

<a name='M-EasyITSystemCenter-Pages-LocSrvWebTmpViewerPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-MainWindow'></a>
## MainWindow `type`

##### Namespace

EasyITSystemCenter

##### Summary

MainWindow

<a name='M-EasyITSystemCenter-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

System Core AND ALL shared functionalities

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-MainWindow-lastUserAction'></a>
### lastUserAction `constants`

##### Summary

MainControls Screen Variables

<a name='P-EasyITSystemCenter-MainWindow-DataGridSelected'></a>
### DataGridSelected `property`

##### Summary

Indicator for Enable New DataGrid Button

<a name='P-EasyITSystemCenter-MainWindow-DataGridSelectedIdListIndicator'></a>
### DataGridSelectedIdListIndicator `property`

##### Summary

[DataGrid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.DataGrid 'System.Windows.Controls.DataGrid') have selected record indicator

<a name='P-EasyITSystemCenter-MainWindow-DgRefresh'></a>
### DgRefresh `property`

##### Summary

Indicator for enable Refresh Button Indicator

<a name='P-EasyITSystemCenter-MainWindow-DownloadShow'></a>
### DownloadShow `property`

##### Summary

Indicator for show Downloading area

<a name='P-EasyITSystemCenter-MainWindow-DownloadStatus'></a>
### DownloadStatus `property`

##### Summary

Downloading of update status variable

<a name='P-EasyITSystemCenter-MainWindow-MultiSameTabsEnabled'></a>
### MultiSameTabsEnabled `property`

##### Summary

Enable/Disable MultiSameTabs Forms

<a name='P-EasyITSystemCenter-MainWindow-OperationRunning'></a>
### OperationRunning `property`

##### Summary

Indicator for mark operation status for any programmatic operations

<a name='P-EasyITSystemCenter-MainWindow-ProgressRing'></a>
### ProgressRing `property`

##### Summary

ProgressRing Visibility indicator

<a name='P-EasyITSystemCenter-MainWindow-RunReleaseMode'></a>
### RunReleaseMode `property`

<a name='P-EasyITSystemCenter-MainWindow-ServerLoggerSource'></a>
### ServerLoggerSource `property`

##### Summary

System Logger Source Status and Controller This is status of Settings System Logger Source

<a name='P-EasyITSystemCenter-MainWindow-ServiceRunning'></a>
### ServiceRunning `property`

##### Summary

Service Status description

<a name='P-EasyITSystemCenter-MainWindow-ServiceStatus'></a>
### ServiceStatus `property`

##### Summary

Service Status public Variable

<a name='P-EasyITSystemCenter-MainWindow-ShowSystemLogger'></a>
### ShowSystemLogger `property`

##### Summary

System Logger Activator by Setted Parametr Can be setted for All Apps or Every User individually

<a name='P-EasyITSystemCenter-MainWindow-SystemLogger'></a>
### SystemLogger `property`

##### Summary

System Online Logger for EASY developing

<a name='P-EasyITSystemCenter-MainWindow-UserLogged'></a>
### UserLogged `property`

##### Summary

User Logged Status

<a name='P-EasyITSystemCenter-MainWindow-VncRunning'></a>
### VncRunning `property`

<a name='M-EasyITSystemCenter-MainWindow-AddOrRemoveTab-System-String,System-Object,System-String-'></a>
### AddOrRemoveTab(headerName,tabPage,tagText) `method`

##### Summary

Tabs Pages control for Insert/Move/Change Pages

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| headerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| tabPage | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| tagText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-MainWindow-BtnKeyboardClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnKeyboardClick(sender,e) `method`

##### Summary

System tools controllers

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-BtnShowLoggerClick-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnShowLoggerClick(sender,e) `method`

##### Summary

Show System On line Logger

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Btn_LaunchHelp_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_LaunchHelp_Click(sender,e) `method`

##### Summary

Help button controller for Show Help File

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Btn_ShowModulePanel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_ShowModulePanel_Click(sender,e) `method`

##### Summary

Show Metro Theme possibilities

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Btn_about_click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Btn_about_click(sender,e) `method`

##### Summary

about applications information

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-CbFilterDropDownClosed-System-Object,System-EventArgs-'></a>
### CbFilterDropDownClosed(sender,e) `method`

##### Summary

Full dynamic apply sett ed filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-CbPrintReportsSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### CbPrintReportsSelected(sender,e) `method`

##### Summary

Print Report Selection Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-FilterField_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### FilterField_SelectionChanged(sender,e) `method`

##### Summary

Full dynamic set sign DataGrid advanced filter type

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-MainWindow-LoadUserMenu'></a>
### LoadUserMenu() `method`

##### Summary

Load UserMenu After Login And Sort

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-MainWindow-MainGrid_IsDraggingChanged-System-Object,System-Windows-RoutedPropertyChangedEventArgs{System-Boolean}-'></a>
### MainGrid_IsDraggingChanged(sender,e) `method`

##### Summary

Dragging and separate to more Applications: TabPanel drag Controller - not Used

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedPropertyChangedEventArgs 'System.Windows.RoutedPropertyChangedEventArgs{System.Boolean}') |  |

<a name='M-EasyITSystemCenter-MainWindow-MainWindow_Closing-System-Object,System-ComponentModel-CancelEventArgs-'></a>
### MainWindow_Closing(sender,e) `method`

##### Summary

Applications Close Request Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.ComponentModel.CancelEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.CancelEventArgs 'System.ComponentModel.CancelEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-MainWindow_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### MainWindow_KeyDown(sender,e) `method`

##### Summary

MainWindow Keyboard pointer to Keyboard Central Application controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-MainWindow_Loaded-System-Object,System-Windows-RoutedEventArgs-'></a>
### MainWindow_Loaded(sender,e) `method`

##### Summary

Application Loaded Start Backend timer for check server set Theme

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Menu_action_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Menu_action_Click(sender,e) `method`

##### Summary

THIS IS AUTOMATIC INCLUDE DATALIST VIEW MENU in FORMAT APIcallPage open or select
existed TabPanel VERTICAL MENU - Copy and CHANGE ONLY Page Name AND Report CALL as /XXXX

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Mi_filter_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Mi_filter_Click(sender,e) `method`

##### Summary

Full dynamic Show/Hidden DataGrid advanced Filter Menu

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-Mi_logout_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### Mi_logout_Click(sender,e) `method`

##### Summary

Application Logout button Controller

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-RemoveFilterItem_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### RemoveFilterItem_Click(sender,e) `method`

##### Summary

Full dynamic Remove Item from DataGrid advanced Filter

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-SetServiceStop'></a>
### SetServiceStop() `method`

##### Summary

Server is unavailable All operations are blocked

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-MainWindow-SetSystemModuleListPanel'></a>
### SetSystemModuleListPanel() `method`

##### Summary

Set System Module Content

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-MainWindow-ShowLoginDialog'></a>
### ShowLoginDialog() `method`

##### Summary

Application Login Dialog

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-MainWindow-ShowMessageOnMainWindow-System-Boolean,System-String,System-Boolean-'></a>
### ShowMessageOnMainWindow(error,message,confirm) `method`

##### Summary

Central Application Message Dialog for All Info / Error / other messages for User

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| error | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| confirm | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITSystemCenter-MainWindow-StringToFilter-System-Windows-Controls-ComboBox,System-String-'></a>
### StringToFilter(filterBox,advancedFilter) `method`

##### Summary

Full dynamic build filter on selected page from saved advanced filter

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filterBox | [System.Windows.Controls.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ComboBox 'System.Windows.Controls.ComboBox') |  |
| advancedFilter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-MainWindow-SystemLoggerSourceChanged_Click-System-Object,System-EventArgs-'></a>
### SystemLoggerSourceChanged_Click(sender,e) `method`

##### Summary

System Logger Source Selector Server Logger has Source From Client Settings by WebSocket URL

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') | The [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-MainWindow-SystemModulePanel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### SystemModulePanel_Click(sender,e) `method`

##### Summary

Open Selected System Module

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-SystemTimerController-System-Object,System-Timers-ElapsedEventArgs-'></a>
### SystemTimerController(sender,e) `method`

##### Summary

Backend System Timer for check server connection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Timers.ElapsedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Timers.ElapsedEventArgs 'System.Timers.ElapsedEventArgs') |  |

<a name='M-EasyITSystemCenter-MainWindow-TabPanelOnSelectionChange-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### TabPanelOnSelectionChange(sender,e) `method`

##### Summary

Tab click selection change reload ID and Pointers for ListView Buttons

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-MainWindow-TiltOpenForm-System-String-'></a>
### TiltOpenForm(translateHeader) `method`

##### Summary

Tilts: Standardized Opening or create Tilt documents

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| translateHeader | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-EasyITSystemCenter-GlobalOperations-MediaOperations'></a>
## MediaOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

<a name='M-EasyITSystemCenter-GlobalOperations-MediaOperations-ArrayToImage-System-Byte[]-'></a>
### ArrayToImage(array) `method`

##### Summary

Cresate Bitmap Image from DB array to Image for show preview

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-MediaOperations-CreateImageFile-System-IO-FileStream,System-Windows-Media-Imaging-BitmapFrame,System-String-'></a>
### CreateImageFile(file,frame,fileType) `method`

##### Summary

Create More Image File Types NotUsed

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.IO.FileStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileStream 'System.IO.FileStream') |  |
| frame | [System.Windows.Media.Imaging.BitmapFrame](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Media.Imaging.BitmapFrame 'System.Windows.Media.Imaging.BitmapFrame') |  |
| fileType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-MediaOperations-GetImageImmediatelly-System-String-'></a>
### GetImageImmediatelly(path) `method`

##### Summary

Important Closing connections of openned files by Form and binding this is solution for
close oppened file after load Solution for All Files

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-MediaOperations-SaveAppScreenShot-EasyITSystemCenter-MainWindow,System-Boolean-'></a>
### SaveAppScreenShot(MainWindow,returnArrayOnly) `method`

##### Summary

ScreenShot Function For Application Menu Tool If Return Array True, Image is returned in
response Other Save Dialog is Opened

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| MainWindow | [EasyITSystemCenter.MainWindow](#T-EasyITSystemCenter-MainWindow 'EasyITSystemCenter.MainWindow') | The main window. |
| returnArrayOnly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-Interact-Model-MenuItem'></a>
## MenuItem `type`

##### Namespace

EasyITSystemCenter.Interact.Model

<a name='F-EasyITSystemCenter-Interact-Model-MenuItem-NavigationDestinationProperty'></a>
### NavigationDestinationProperty `constants`

##### Summary

Identifies the [NavigationDestination](#P-EasyITSystemCenter-Interact-Model-MenuItem-NavigationDestination 'EasyITSystemCenter.Interact.Model.MenuItem.NavigationDestination') dependency property.

<a name='F-EasyITSystemCenter-Interact-Model-MenuItem-NavigationTypeProperty'></a>
### NavigationTypeProperty `constants`

##### Summary

Identifies the [NavigationType](#P-EasyITSystemCenter-Interact-Model-MenuItem-NavigationType 'EasyITSystemCenter.Interact.Model.MenuItem.NavigationType') dependency property.

<a name='T-EasyITSystemCenter-GlobalStyles-MergedStylesExtension'></a>
## MergedStylesExtension `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

Style Includer Definition, 
merge more styles to One For Use  Metro Default Definiton + Custom Modifications
Using Example:

<a name='T-EasyITSystemCenter-Pages-MltEicSrvWebAppPage'></a>
## MltEicSrvWebAppPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

MltEicSrvWebAppPage

<a name='M-EasyITSystemCenter-Pages-MltEicSrvWebAppPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage'></a>
## MltTblGenEsbSrvFormPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

MltTblGenEsbSrvFormPage

<a name='M-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage-GetGenericTableData'></a>
### GetGenericTableData() `method`

##### Summary

Generic API Request

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-MltTblGenEsbSrvFormPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Tools-MyCompletionData'></a>
## MyCompletionData `type`

##### Namespace

EasyITSystemCenter.Tools

##### Summary

Implements AvalonEdit ICompletionData interface to provide the entries in the completion drop down.

<a name='T-EasyITSystemCenter-SystemHelper-OWinApiMiddleWare'></a>
## OWinApiMiddleWare `type`

##### Namespace

EasyITSystemCenter.SystemHelper

##### Summary

System Logger Helper Defined Central WebSocket Monitor Controller

<a name='T-EasyITSystemCenter-Pages-ProdGuidGroupListPage'></a>
## ProdGuidGroupListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ProdGuidGroupListPage

<a name='M-EasyITSystemCenter-Pages-ProdGuidGroupListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ProdGuidOperationListPage'></a>
## ProdGuidOperationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ProdGuidOperationListPage

<a name='M-EasyITSystemCenter-Pages-ProdGuidOperationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ProdGuidPartListPage'></a>
## ProdGuidPartListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ProdGuidPartListPage

<a name='M-EasyITSystemCenter-Pages-ProdGuidPartListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ProdGuidPersonListPage'></a>
## ProdGuidPersonListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ProdGuidPersonListPage

<a name='M-EasyITSystemCenter-Pages-ProdGuidPersonListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ProdGuidWorkListPage'></a>
## ProdGuidWorkListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ProdGuidWorkListPage

<a name='M-EasyITSystemCenter-Pages-ProdGuidWorkListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalStyles-ProgramaticStyles'></a>
## ProgramaticStyles `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

<a name='M-EasyITSystemCenter-GlobalStyles-ProgramaticStyles-GridTextRightAligment'></a>
### GridTextRightAligment() `method`

##### Summary

DataGrid Column Right Aligment

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations'></a>
## ProgrammaticOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

<a name='M-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations-ConvertStringTypeValueToSpecTypeByKnownTypeName-System-String,System-String-'></a>
### ConvertStringTypeValueToSpecTypeByKnownTypeName() `method`

##### Summary

Global DataTypes Chwecker with Bool Result Used on System Parameters

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-ProgrammaticOperations-DetectTypeValueFromObject-System-Object-'></a>
### DetectTypeValueFromObject(typeString,value) `method`

##### Summary

Detection of Value Type for Xaml  Generators 
By Type are Defined Input Fields

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeString | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |

<a name='T-EasyITSystemCenter-Properties-Resources'></a>
## Resources `type`

##### Namespace

EasyITSystemCenter.Properties

##### Summary

Třída prostředků se silnými typy pro vyhledávání lokalizovaných řetězců atp.

<a name='P-EasyITSystemCenter-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Potlačí vlastnost CurrentUICulture aktuálního vlákna pro všechna
  vyhledání prostředků pomocí třídy prostředků se silnými typy.

<a name='P-EasyITSystemCenter-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Vrací instanci ResourceManager uloženou v mezipaměti použitou touto třídou.

<a name='T-EasyITSystemCenter-Pages-ScreenSaverPage'></a>
## ScreenSaverPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ScreenSaverPage

<a name='M-EasyITSystemCenter-Pages-ScreenSaverPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerApiSecurityListPage'></a>
## ServerApiSecurityListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerApiSecurityListPage

<a name='M-EasyITSystemCenter-Pages-ServerApiSecurityListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerCorsDefAllowedOriginListPage'></a>
## ServerCorsDefAllowedOriginListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerCorsDefAllowedOriginListPage

<a name='M-EasyITSystemCenter-Pages-ServerCorsDefAllowedOriginListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerHealthCheckTaskListPage'></a>
## ServerHealthCheckTaskListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerHealthCheckTaskListPage

<a name='M-EasyITSystemCenter-Pages-ServerHealthCheckTaskListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerLiveDataMonitorListPage'></a>
## ServerLiveDataMonitorListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerLiveDataMonitorListPage

<a name='M-EasyITSystemCenter-Pages-ServerLiveDataMonitorListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerModuleAndServiceListPage'></a>
## ServerModuleAndServiceListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerModuleAndServiceListPage

<a name='M-EasyITSystemCenter-Pages-ServerModuleAndServiceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerStaticOrMvcDefPathListPage'></a>
## ServerStaticOrMvcDefPathListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerStaticOrMvcDefPathListPage

<a name='M-EasyITSystemCenter-Pages-ServerStaticOrMvcDefPathListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerToolPanelDefinitionListPage'></a>
## ServerToolPanelDefinitionListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerToolPanelDefinitionListPage

<a name='M-EasyITSystemCenter-Pages-ServerToolPanelDefinitionListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerToolPanelListPage'></a>
## ServerToolPanelListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerToolPanelListPage

<a name='M-EasyITSystemCenter-Pages-ServerToolPanelListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-ServerToolTypeListPage'></a>
## ServerToolTypeListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

ServerToolTypeListPage

<a name='M-EasyITSystemCenter-Pages-ServerToolTypeListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionEmailTemplateListPage'></a>
## SolutionEmailTemplateListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionEmailTemplateListPage

<a name='M-EasyITSystemCenter-Pages-SolutionEmailTemplateListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionEmailerHistoryListPage'></a>
## SolutionEmailerHistoryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionEmailerHistoryListPage

<a name='M-EasyITSystemCenter-Pages-SolutionEmailerHistoryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionFailListPage'></a>
## SolutionFailListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionFailListPage

<a name='M-EasyITSystemCenter-Pages-SolutionFailListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionLanguageListPage'></a>
## SolutionLanguageListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionLanguageListPage

<a name='M-EasyITSystemCenter-Pages-SolutionLanguageListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionMessageModuleListPage'></a>
## SolutionMessageModuleListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionMessageModuleListPage

<a name='M-EasyITSystemCenter-Pages-SolutionMessageModuleListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionMessageTypeListPage'></a>
## SolutionMessageTypeListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionMessageTypeListPage

<a name='M-EasyITSystemCenter-Pages-SolutionMessageTypeListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionMixedEnumListPage'></a>
## SolutionMixedEnumListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionMixedEnumListPage

<a name='M-EasyITSystemCenter-Pages-SolutionMixedEnumListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionMottoListPage'></a>
## SolutionMottoListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionMottoListPage

<a name='M-EasyITSystemCenter-Pages-SolutionMottoListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionOperationListPage'></a>
## SolutionOperationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionOperationListPage

<a name='M-EasyITSystemCenter-Pages-SolutionOperationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionSchedulerListPage'></a>
## SolutionSchedulerListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionSchedulerListPage

<a name='M-EasyITSystemCenter-Pages-SolutionSchedulerListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionStaticFileListPage'></a>
## SolutionStaticFileListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionStaticFileListPage

<a name='M-EasyITSystemCenter-Pages-SolutionStaticFileListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionTaskListPage'></a>
## SolutionTaskListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionTaskListPage

<a name='M-EasyITSystemCenter-Pages-SolutionTaskListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionUserListPage'></a>
## SolutionUserListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionUserListPage

<a name='M-EasyITSystemCenter-Pages-SolutionUserListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionUserRoleListPage'></a>
## SolutionUserRoleListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionUserRoleListPage

<a name='M-EasyITSystemCenter-Pages-SolutionUserRoleListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SolutionWebsiteListPage'></a>
## SolutionWebsiteListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SolutionWebsiteListPage

<a name='M-EasyITSystemCenter-Pages-SolutionWebsiteListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Startup'></a>
## Startup `type`

##### Namespace

EasyITSystemCenter

##### Summary

Local WebServwer Startup

<a name='T-EasyITSystemCenter-Pages-SupportPage'></a>
## SupportPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SupportPage

<a name='M-EasyITSystemCenter-Pages-SupportPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemCustomPageListPage'></a>
## SystemCustomPageListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemCustomPageListPage

<a name='M-EasyITSystemCenter-Pages-SystemCustomPageListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemDocumentAdviceListPage'></a>
## SystemDocumentAdviceListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemDocumentAdviceListPage

<a name='M-EasyITSystemCenter-Pages-SystemDocumentAdviceListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemGroupMenuListPage'></a>
## SystemGroupMenuListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemGroupMenuListPage

<a name='M-EasyITSystemCenter-Pages-SystemGroupMenuListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemIgnoredExceptionListPage'></a>
## SystemIgnoredExceptionListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemIgnoredExceptionListPage

<a name='M-EasyITSystemCenter-Pages-SystemIgnoredExceptionListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets'></a>
## SystemLocalEnumSets `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

<a name='F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-ConfigTypes'></a>
### ConfigTypes `constants`

##### Summary

Client Setting offline enum Menu Groups

<a name='F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-Languages'></a>
### Languages `constants`

##### Summary

Client Setting Offline enum of Languages

<a name='F-EasyITSystemCenter-GlobalClasses-SystemLocalEnumSets-UpdateVariants'></a>
### UpdateVariants `constants`

##### Summary

Client Setting offline enum Updater States

<a name='T-EasyITSystemCenter-SystemHelper-SystemLoggerWebSocketClass'></a>
## SystemLoggerWebSocketClass `type`

##### Namespace

EasyITSystemCenter.SystemHelper

##### Summary

System Logger WebSocket Monitor Controller Class Definition For Centralized Using

<a name='T-EasyITSystemCenter-Pages-SystemLoginHistoryListPage'></a>
## SystemLoginHistoryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemLoginHistoryListPage

<a name='M-EasyITSystemCenter-Pages-SystemLoginHistoryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemMenuListPage'></a>
## SystemMenuListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemMenuListPage

<a name='M-EasyITSystemCenter-Pages-SystemMenuListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemModuleListPage'></a>
## SystemModuleListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemModuleListPage

<a name='M-EasyITSystemCenter-Pages-SystemModuleListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemMonitorPage'></a>
## SystemMonitorPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemMonitorPage

<a name='M-EasyITSystemCenter-Pages-SystemMonitorPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemOperationListPage'></a>
## SystemOperationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemOperationListPage

<a name='M-EasyITSystemCenter-Pages-SystemOperationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalOperations-SystemOperations'></a>
## SystemOperations `type`

##### Namespace

EasyITSystemCenter.GlobalOperations

##### Summary

Centralised System Functions for work with Types, methods, Formats, Logic, supported methods

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-FilterToString-System-Windows-Controls-ComboBox-'></a>
### FilterToString(filterBox) `method`

##### Summary

SYSTEM Advanced Filter Conversion for API return existing filter for saving to string in
selected Page

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filterBox | [System.Windows.Controls.ComboBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.ComboBox 'System.Windows.Controls.ComboBox') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-FirstLetterToLower-System-String-'></a>
### FirstLetterToLower(str) `method`

##### Summary

Change First Character of String

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string. |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetExceptionMessages-System-Exception,System-Int32-'></a>
### GetExceptionMessages(exception,msgCount) `method`

##### Summary

Mining All Exception Information For Central System Logger Ignore Some selected Fails is
possible by Ignored Exception Settings

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetExceptionMessagesAll-System-Exception,System-Int32-'></a>
### GetExceptionMessagesAll(exception,msgCount) `method`

##### Summary

Mining All Exception Information For Local System Logger EveryTime Show All fails for
Best Developing On Expert Level

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| exception | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') |  |
| msgCount | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetLanguageCode-System-String-'></a>
### GetLanguageCode(languageDefault) `method`

##### Summary

Get Language Code 
Used By Tools Automatic Setting for tools

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| languageDefault | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-GetSystemLocalhostFreePort'></a>
### GetSystemLocalhostFreePort() `method`

##### Summary

Get First Free Port For Start Local Web Server
Used By reactive Web Server

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-IncreaseFileVersionBuild'></a>
### IncreaseFileVersionBuild() `method`

##### Summary

Automatic Increase version System Ideal for small systems with more release in 1 day
Increase Windows Correct 3 position for Widows Installation In Debug is increase last 4 position

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-PortInUse-System-Int32-'></a>
### PortInUse(port) `method`

##### Summary

System Port Checker

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-RandomString-System-Int32-'></a>
### RandomString(length) `method`

##### Summary

Generate Random String with defined length

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-RemoveAppNamespaceFromString-System-String-'></a>
### RemoveAppNamespaceFromString(stringForRemoveNamespace) `method`

##### Summary

Its Solution for this is a solution for demanding and multiplied servers Or Running
SHARP and Test System By One Backend Server Service API Urls with Namespaces in Name are
for Backend model with More Same Database Schemas Backend Databases count in One Server
Service is Unlimited

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stringForRemoveNamespace | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-SendMailWithMailTo-System-String,System-String,System-String,System-String-'></a>
### SendMailWithMailTo(address,subject,body,attach) `method`

##### Summary

System Mail sending

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| address | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| subject | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| body | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| attach | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-SendMailWithServerSetting-System-String-'></a>
### SendMailWithServerSetting(message) `method`

##### Summary

Email Sender for send Direct Email by Server Configuration for Testing

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The message. |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-SetLanguageDictionary-System-Windows-ResourceDictionary,System-String-'></a>
### SetLanguageDictionary(Resources,languageDefault) `method`

##### Summary

Settings Local Application Translation dictionaries (Resources Files) for Pages Will be
replaced by DBDictionary, but for Offline Running must be possible

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| Resources | [System.Windows.ResourceDictionary](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.ResourceDictionary 'System.Windows.ResourceDictionary') |  |
| languageDefault | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-GlobalOperations-SystemOperations-StartExternalProccess-System-String,System-String,System-String,System-String-'></a>
### StartExternalProccess(type,processCommand,startupPath,arguments) `method`

##### Summary

System External Process Starter for Conrtalized Using Return the processId when is
 started or null

 TODO
 - create process Monitor
 - save the monitored procceses to System Monitor
 - must be refactored actual status

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| processCommand | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| startupPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The startup path. |
| arguments | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The arguments. |

<a name='T-EasyITSystemCenter-Pages-SystemParameterListPage'></a>
## SystemParameterListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemParameterListPage

<a name='M-EasyITSystemCenter-Pages-SystemParameterListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemReportListPage'></a>
## SystemReportListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemReportListPage

<a name='M-EasyITSystemCenter-Pages-SystemReportListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-SystemReportQueueListPage'></a>
## SystemReportQueueListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemReportQueueListPage

<a name='M-EasyITSystemCenter-Pages-SystemReportQueueListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-SystemStatuses'></a>
## SystemStatuses `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

!!SYSTEM Global Definition for System Statuses

 SYSTEM Running mode In debug mode is disabled the System Logger Visual Studio Debugger
 difficult operation has problem If you want you can enable SystemLogger by change to: DebugWithSystemLogger

 Its Used as String EveryWhere Its good Soution for Centarized Statuses of System Errors Are
 Saved In SystemLogger or Database

<a name='T-EasyITSystemCenter-Pages-SystemSvgIconListPage'></a>
## SystemSvgIconListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemSvgIconListPage

<a name='M-EasyITSystemCenter-Pages-SystemSvgIconListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalClasses-SystemTranslatedTableList'></a>
## SystemTranslatedTableList `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Class for Using as customized list the List of API urls for Central using in the system One
Api is One: Dataview / Right / Report Posibility / Menu Item / Page Exist rules for
automatic processing in System Core Logic for simple Developing

<a name='T-EasyITSystemCenter-Pages-SystemTranslationListPage'></a>
## SystemTranslationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

SystemTranslationListPage

<a name='M-EasyITSystemCenter-Pages-SystemTranslationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-SystemStructure-SystemWindowDataModel'></a>
## SystemWindowDataModel `type`

##### Namespace

EasyITSystemCenter.SystemStructure

<a name='M-EasyITSystemCenter-SystemStructure-SystemWindowDataModel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Its Solution For MultiInstance Application If The InterTab Is Enabled Can be Dragged Tab
To the New Application

##### Parameters

This constructor has no parameters.

<a name='T-EasyITSystemCenter-Pages-TabItemPage'></a>
## TabItemPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

Interaction logic for AccentStyleWindow.xaml

<a name='M-EasyITSystemCenter-Pages-TabItemPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationPage'></a>
## TemplateClassListAutoDBTranslationPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListAutoDBTranslationPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationViewPage'></a>
## TemplateClassListAutoDBTranslationViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListAutoDBTranslationViewPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithParentPage'></a>
## TemplateClassListAutoDBTranslationWithParentPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListAutoDBTranslationWithParentPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithParentPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage'></a>
## TemplateClassListAutoDBTranslationWithSubPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

This standartized Template is only for list view od Data table Called from MainWindow.cs on
open New Tab

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data Manual work needed
Translate All XAML fields by Resources Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages this method is
 for global working with pages Called from MainWindow.cs for Control of Button Menu and
 Selections (Report,Filter and more) All is setted as global Classes for All Pages and
 Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnCancel_Click(sender,e) `method`

##### Summary

Standartized method for cancel of Editing. Hide Detail and Dataview List is Shown This
is full automatic, not needed manual work This is on Every page ('View' and 'Form'
Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is
for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnItemDelete_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnItemDelete_Click(sender,e) `method`

##### Summary

Standartized method for Direct Delete SubRecord to SubListView Manual work needed, set
correct data set for SubRecord This is on page With Sublist ('View' and 'Form' Types)
without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnItemInsert_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnItemInsert_Click(sender,e) `method`

##### Summary

Standartized method for Direct Insert SubRecord to SubListView Manual work needed, set
correct data set for SubRecord This is on page With Sublist ('View' and 'Form' Types)
without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnSave_Click(sender,e) `method`

##### Summary

Standartized method for Save Record And return to Dataview. Manual work need, Here is
Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction FORM
to SELECTED RECORD By ClasName Replacing All other changes are automaticaly
(API,DatasetType), just must define and control Each Field Of Dataset this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-ClearItemsFields'></a>
### ClearItemsFields() `method`

##### Summary

Standartized Method for Clear SubRecord Input Fields with custom Dataset For Correct
Using must be Fields changed for used dataset

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### Customer_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox This is full automatic, not needed
manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Delete button Click Show MainWindow Standartized Message with info About Delete and
After confirm Send DeleteApiRequest Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that
is only for Select record This is full automatic, not needed manual work This is on
Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### DgListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on Every page ('View' and 'Form' Types) without 'Setting' Type
(Name=Setting and Tag=Setting in XAML part) this method is for global working page its
local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Edit button Click Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the
simple 'Search Input' for DatagidView (List Data) Manual Changing is needed of filtered
columns by Search Value This is on Every page ('View' and 'Form' Types) without
'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for global
working with pages Called from MainWindow.cs Dynamicaly Called Only from MainWindow.cs
when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data. Manual Changing is needed for simple form is All
 changed By CLASNAME Chage, but If you need More API data for selection Here are Defined
 All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
New button Click Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### NotesChanged(sender,e) `method`

##### Summary

Standartized Maximal Simle Code with Reaction and Fill input After ParentComboboxSelection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### PartNumberGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in
Combobox This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### PartNumber_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox This is full automatic, not needed
manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectCustomer_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input This is
full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### SelectGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in
Combobox This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectPartNumber_Enter(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on page With Sublist ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') | The [KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetCustomer'></a>
### SetCustomer() `method`

##### Summary

Standartized methods For Filling Input after Selection This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetPartNumber'></a>
### SetPartNumber() `method`

##### Summary

Standartized methods For Filling Input after Selection This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetRecord-System-Nullable{System-Boolean},System-Boolean-'></a>
### SetRecord(showForm,copy) `method`

##### Summary

Standartized method for ¨Set New Record/ Edit Record / Copy Record And return to
 Dataview. Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset
 (dataset for Detail): Direction Selected record to FORM By ClasName Replacing All other
 changes are automaticaly (API,DatasetType), just must define and control Each Field Of
 Dataset this method is for global working page its local control From XAML

 In this type Form Here Are loaded Data for SublistView (on knows selected record for
 correct join)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| showForm | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | if set to `true` [show form]. |
| copy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [copy]. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean-'></a>
### SetSubListsNonActiveOnNewItem() `method`

##### Summary

Standartized Method for Load All SubData which is needed for Working with SubRecord For
Correct Using must be changed for actual datasets

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-UpdateCustomerSearchResults'></a>
### UpdateCustomerSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-UpdatePartNumberSearchResults'></a>
### UpdatePartNumberSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubPage-dgSubListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### dgSubListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on page With Sublist ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='T-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage'></a>
## TemplateClassListAutoDBTranslationWithSubViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

This standartized Template is only for list view od Data table Called from MainWindow.cs on
open New Tab

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data Manual work needed
Translate All XAML fields by Resources Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages this method is
 for global working with pages Called from MainWindow.cs for Control of Button Menu and
 Selections (Report,Filter and more) All is setted as global Classes for All Pages and
 Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnCancel_Click(sender,e) `method`

##### Summary

Standartized method for cancel of Editing. Hide Detail and Dataview List is Shown This
is full automatic, not needed manual work This is on Every page ('View' and 'Form'
Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is
for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnSave_Click(sender,e) `method`

##### Summary

Standartized method for Save Record And return to Dataview. Manual work need, Here is
Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction FORM
to SELECTED RECORD By ClasName Replacing All other changes are automaticaly
(API,DatasetType), just must define and control Each Field Of Dataset this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Delete button Click Show MainWindow Standartized Message with info About Delete and
After confirm Send DeleteApiRequest Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that
is only for Select record This is full automatic, not needed manual work This is on
Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### DgListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on Every page ('View' and 'Form' Types) without 'Setting' Type
(Name=Setting and Tag=Setting in XAML part) this method is for global working page its
local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Edit button Click Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the
simple 'Search Input' for DatagidView (List Data) Manual Changing is needed of filtered
columns by Search Value This is on Every page ('View' and 'Form' Types) without
'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for global
working with pages Called from MainWindow.cs Dynamicaly Called Only from MainWindow.cs
when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-Fixed_Checked-System-Object,System-Windows-RoutedEventArgs-'></a>
### Fixed_Checked(sender,e) `method`

##### Summary

Standartized method for Loading Data for Selected Record This is full automatic, not
needed manual work This is on Every page ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data. Manual Changing is needed for simple form is All
 changed By CLASNAME Chage, but If you need More API data for selection Here are Defined
 All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-LoadSubDataList'></a>
### LoadSubDataList() `method`

##### Summary

Standartized Method for Loading SubData. Manual Changing is needed for simple form is
 All changed By CLASNAME Chage, but If you need More API data for selection Here are
 Defined All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
New button Click Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListAutoDBTranslationWithSubViewPage-SetRecord-System-Nullable{System-Boolean},System-Boolean-'></a>
### SetRecord(showForm,copy) `method`

##### Summary

Standartized method for ¨Set New Record/ Edit Record / Copy Record And return to
 Dataview. Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset
 (dataset for Detail): Direction Selected record to FORM By ClasName Replacing All other
 changes are automaticaly (API,DatasetType), just must define and control Each Field Of
 Dataset this method is for global working page its local control From XAML

 In this type Form Here Are loaded Data for SublistView (on knows selected record for
 correct join)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| showForm | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | if set to `true` [show form]. |
| copy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [copy]. |

<a name='T-EasyITSystemCenter-Pages-TemplateClassListPage'></a>
## TemplateClassListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListViewPage'></a>
## TemplateClassListViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListViewPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListWithParentPage'></a>
## TemplateClassListWithParentPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateClassListWithParentPage

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithParentPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateClassListWithSubPage'></a>
## TemplateClassListWithSubPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

This standartized Template is only for list view od Data table Called from MainWindow.cs on
open New Tab

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data Manual work needed
Translate All XAML fields by Resources Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages this method is
 for global working with pages Called from MainWindow.cs for Control of Button Menu and
 Selections (Report,Filter and more) All is setted as global Classes for All Pages and
 Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnCancel_Click(sender,e) `method`

##### Summary

Standartized method for cancel of Editing. Hide Detail and Dataview List is Shown This
is full automatic, not needed manual work This is on Every page ('View' and 'Form'
Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is
for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnItemDelete_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnItemDelete_Click(sender,e) `method`

##### Summary

Standartized method for Direct Delete SubRecord to SubListView Manual work needed, set
correct data set for SubRecord This is on page With Sublist ('View' and 'Form' Types)
without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnItemInsert_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnItemInsert_Click(sender,e) `method`

##### Summary

Standartized method for Direct Insert SubRecord to SubListView Manual work needed, set
correct data set for SubRecord This is on page With Sublist ('View' and 'Form' Types)
without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnSave_Click(sender,e) `method`

##### Summary

Standartized method for Save Record And return to Dataview. Manual work need, Here is
Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction FORM
to SELECTED RECORD By ClasName Replacing All other changes are automaticaly
(API,DatasetType), just must define and control Each Field Of Dataset this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-ClearItemsFields'></a>
### ClearItemsFields() `method`

##### Summary

Standartized Method for Clear SubRecord Input Fields with custom Dataset For Correct
Using must be Fields changed for used dataset

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-Customer_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### Customer_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox This is full automatic, not needed
manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Delete button Click Show MainWindow Standartized Message with info About Delete and
After confirm Send DeleteApiRequest Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that
is only for Select record This is full automatic, not needed manual work This is on
Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### DgListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on Every page ('View' and 'Form' Types) without 'Setting' Type
(Name=Setting and Tag=Setting in XAML part) this method is for global working page its
local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Edit button Click Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the
simple 'Search Input' for DatagidView (List Data) Manual Changing is needed of filtered
columns by Search Value This is on Every page ('View' and 'Form' Types) without
'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for global
working with pages Called from MainWindow.cs Dynamicaly Called Only from MainWindow.cs
when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data. Manual Changing is needed for simple form is All
 changed By CLASNAME Chage, but If you need More API data for selection Here are Defined
 All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
New button Click Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-NotesChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### NotesChanged(sender,e) `method`

##### Summary

Standartized Maximal Simle Code with Reaction and Fill input After ParentComboboxSelection

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-PartNumberGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### PartNumberGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in
Combobox This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-PartNumber_KeyDown-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### PartNumber_KeyDown(sender,e) `method`

##### Summary

Standartized method for Keyboard control of SelectBox This is full automatic, not needed
manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectCustomer_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectCustomer_Enter(sender,e) `method`

##### Summary

Standartized methods with Indicate Customer Selection and Start Filling Input This is
full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectGotFocus-System-Object,System-Windows-RoutedEventArgs-'></a>
### SelectGotFocus(sender,e) `method`

##### Summary

Standartized method indicate start loading all data of SubRecord after Selected in
Combobox This is full automatic, not needed manual work

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SelectPartNumber_Enter-System-Object,System-Windows-Input-KeyEventArgs-'></a>
### SelectPartNumber_Enter(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on page With Sublist ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Input.KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') | The [KeyEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetCustomer'></a>
### SetCustomer() `method`

##### Summary

Standartized methods For Filling Input after Selection This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetPartNumber'></a>
### SetPartNumber() `method`

##### Summary

Standartized methods For Filling Input after Selection This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetRecord-System-Nullable{System-Boolean},System-Boolean-'></a>
### SetRecord(showForm,copy) `method`

##### Summary

Standartized method for ¨Set New Record/ Edit Record / Copy Record And return to
 Dataview. Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset
 (dataset for Detail): Direction Selected record to FORM By ClasName Replacing All other
 changes are automaticaly (API,DatasetType), just must define and control Each Field Of
 Dataset this method is for global working page its local control From XAML

 In this type Form Here Are loaded Data for SublistView (on knows selected record for
 correct join)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| showForm | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | if set to `true` [show form]. |
| copy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [copy]. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-SetSubListsNonActiveOnNewItem-System-Boolean-'></a>
### SetSubListsNonActiveOnNewItem() `method`

##### Summary

Standartized Method for Load All SubData which is needed for Working with SubRecord For
Correct Using must be changed for actual datasets

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-UpdateCustomerSearchResults'></a>
### UpdateCustomerSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-UpdatePartNumberSearchResults'></a>
### UpdatePartNumberSearchResults() `method`

##### Summary

Standartized method Filling Customer Input by Selected Value This is full automatic, not
needed manual work

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubPage-dgSubListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### dgSubListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on page With Sublist ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='T-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage'></a>
## TemplateClassListWithSubViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

This standartized Template is only for list view od Data table Called from MainWindow.cs on
open New Tab

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data Manual work needed
Translate All XAML fields by Resources Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data and selected record for All Pages this method is
 for global working with pages Called from MainWindow.cs for Control of Button Menu and
 Selections (Report,Filter and more) All is setted as global Classes for All Pages and
 Work is Fully automatized by System core

 HERE you Define All Data Variables For This Form

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-BtnCancel_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnCancel_Click(sender,e) `method`

##### Summary

Standartized method for cancel of Editing. Hide Detail and Dataview List is Shown This
is full automatic, not needed manual work This is on Every page ('View' and 'Form'
Types) without 'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is
for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-BtnSave_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnSave_Click(sender,e) `method`

##### Summary

Standartized method for Save Record And return to Dataview. Manual work need, Here is
Join Betwen XAML inputs and Selected Record Dataset (dataset for Detail): Direction FORM
to SELECTED RECORD By ClasName Replacing All other changes are automaticaly
(API,DatasetType), just must define and control Each Field Of Dataset this method is for
global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DeleteRecord'></a>
### DeleteRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Delete button Click Show MainWindow Standartized Message with info About Delete and
After confirm Send DeleteApiRequest Reload Datalist and cancel Selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_MouseDoubleClick-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### DgListView_MouseDoubleClick(sender,e) `method`

##### Summary

Standartized method for selecting and opening Detail Form. This is only View Page, that
is only for Select record This is full automatic, not needed manual work This is on
Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working page its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_SelectionChanged-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### DgListView_SelectionChanged(sender,e) `method`

##### Summary

Standartized method for select one record only. This is full automatic, not needed
manual work This is on Every page ('View' and 'Form' Types) without 'Setting' Type
(Name=Setting and Tag=Setting in XAML part) this method is for global working page its
local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') | The [SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgListView_Translate-System-Object,System-EventArgs-'></a>
### DgListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of DatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-DgSubListView_Translate-System-Object,System-EventArgs-'></a>
### DgSubListView_Translate(sender,ex) `method`

##### Summary

Standartized method for translating column names of SubDatagidView (List Data) Manual
Changing is needed for set Translate of Column Names via Dictionary Items Here you can
set Format(Date,time, etc),Index position, Hide Column, Translate, change grahics Style
This is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
Tag=Setting in XAML part) this method is for global working with page internal reaction
on DatagrigView DataFiling on Start Page Runned On Page Loading

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| ex | [System.EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-EditRecord-System-Boolean-'></a>
### EditRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
Edit button Click Only Set Record And Hide Dataview and Show Detail with selected Record

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-Filter-System-String-'></a>
### Filter(filter) `method`

##### Summary

Standartized method for searching match in setted columns. Searched value is from the
simple 'Search Input' for DatagidView (List Data) Manual Changing is needed of filtered
columns by Search Value This is on Every page ('View' and 'Form' Types) without
'Setting' Type (Name=Setting and Tag=Setting in XAML part) this method is for global
working with pages Called from MainWindow.cs Dynamicaly Called Only from MainWindow.cs
when Search value Inserted

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| filter | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-Fixed_Checked-System-Object,System-Windows-RoutedEventArgs-'></a>
### Fixed_Checked(sender,e) `method`

##### Summary

Standartized method for Loading Data for Selected Record This is full automatic, not
needed manual work This is on Every page ('View' and 'Form' Types) without 'Setting'
Type (Name=Setting and Tag=Setting in XAML part) this method is for global working page
its local control From XAML

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The source of the event. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The [RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') instance containing the event data. |

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-LoadDataList'></a>
### LoadDataList() `method`

##### Summary

Standartized Method for Loading data. Manual Changing is needed for simple form is All
 changed By CLASNAME Chage, but If you need More API data for selection Here are Defined
 All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-LoadSubDataList'></a>
### LoadSubDataList() `method`

##### Summary

Standartized Method for Loading SubData. Manual Changing is needed for simple form is
 All changed By CLASNAME Chage, but If you need More API data for selection Here are
 Defined All incoming Data Loading is same centralized only change ClasName For Diferent Dataset

 After all data for DatagridView (List Data) are loaded The ProgressRing is hidden This
 is on Every page ('View' and 'Form' Types) without 'Setting' Type (Name=Setting and
 Tag=Setting in XAML part) this method is for global working with pages Called from
 MainWindow.cs on Refresh button click Runned on Pageloading or Filter or View Change

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-NewRecord'></a>
### NewRecord() `method`

##### Summary

Standartized Method on All Pages with Forms for New Record ALL Needed changes Are done
By Replace CLASSNAME not needed manual work Dynamicaly Called Only from MainWindow.cs on
New button Click Only Set Record And Hide Dataview and Show Detail

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-TemplateClassListWithSubViewPage-SetRecord-System-Nullable{System-Boolean},System-Boolean-'></a>
### SetRecord(showForm,copy) `method`

##### Summary

Standartized method for ¨Set New Record/ Edit Record / Copy Record And return to
 Dataview. Manual work need, Here is Join Betwen XAML inputs and Selected Record Dataset
 (dataset for Detail): Direction Selected record to FORM By ClasName Replacing All other
 changes are automaticaly (API,DatasetType), just must define and control Each Field Of
 Dataset this method is for global working page its local control From XAML

 In this type Form Here Are loaded Data for SublistView (on knows selected record for
 correct join)

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| showForm | [System.Nullable{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.Boolean}') | if set to `true` [show form]. |
| copy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [copy]. |

<a name='T-EasyITSystemCenter-Pages-TemplateDocumentViewPage'></a>
## TemplateDocumentViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

Template Page For View document, pictures, text and and much more file formats opened in WebViewer

<a name='M-EasyITSystemCenter-Pages-TemplateDocumentViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and direct show example file

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateDocumentViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-EasyITSystemCenter-Pages-TemplateDocumentViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateSTLPage'></a>
## TemplateSTLPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateSTLPage

<a name='F-EasyITSystemCenter-Pages-TemplateSTLPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-EasyITSystemCenter-Pages-TemplateSTLPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateSettingsPage'></a>
## TemplateSettingsPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateSettingsPage

<a name='M-EasyITSystemCenter-Pages-TemplateSettingsPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and start loding data Manual work needed
Translate All XAML fields by Resources Runned on start

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateSettingsPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-EasyITSystemCenter-Pages-TemplateSettingsPage-BtnApiTest_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### BtnApiTest_Click(sender,e) `method`

##### Summary

Customized GET Call

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-TemplateSettingsPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateVideoPage'></a>
## TemplateVideoPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

TemplateVideoPage

<a name='F-EasyITSystemCenter-Pages-TemplateVideoPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-EasyITSystemCenter-Pages-TemplateVideoPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-TemplateWebViewPage'></a>
## TemplateWebViewPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

Template Page For internet pages document, pictures, text and and much more file formats
opened in WebViewer

<a name='M-EasyITSystemCenter-Pages-TemplateWebViewPage-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initialize page with loading Dictionary and direct show example file

##### Parameters

This constructor has no parameters.

<a name='F-EasyITSystemCenter-Pages-TemplateWebViewPage-dataViewSupport'></a>
### dataViewSupport `constants`

##### Summary

Standartized declaring static page data for global vorking with pages

<a name='M-EasyITSystemCenter-Pages-TemplateWebViewPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalStyles-TextBoxBehavior'></a>
## TextBoxBehavior `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

TextBox Behavior SelectAll on Focus
Example of Link in XAML
xmlns:XamlExt="clr-namespace:EasyITSystemCenter.ProgramaticXamlBehaviors"
in TextBox Add behaviors:TextBoxBehavior.SelectAllTextOnFocus="True"

<a name='F-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SelectAllTextOnFocusProperty'></a>
### SelectAllTextOnFocusProperty `constants`

##### Summary

Xaml Property: SelectAllTextOnFocus

<a name='M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-GetSelectAllTextOnFocus-System-Windows-Controls-TextBox-'></a>
### GetSelectAllTextOnFocus(textBox) `method`

##### Summary

Xaml Extension Get Select All On Focus

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textBox | [System.Windows.Controls.TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.TextBox 'System.Windows.Controls.TextBox') |  |

<a name='M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-IgnoreMouseButton-System-Object,System-Windows-Input-MouseButtonEventArgs-'></a>
### IgnoreMouseButton(sender,e) `method`

##### Summary

Ignores the mouse button.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender. |
| e | [System.Windows.Input.MouseButtonEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.MouseButtonEventArgs 'System.Windows.Input.MouseButtonEventArgs') | The e. |

<a name='M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-OnSelectAllTextOnFocusChanged-System-Windows-DependencyObject,System-Windows-DependencyPropertyChangedEventArgs-'></a>
### OnSelectAllTextOnFocusChanged(d,e) `method`

##### Summary

Ons the select all text on focus changed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| d | [System.Windows.DependencyObject](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyObject 'System.Windows.DependencyObject') | The d. |
| e | [System.Windows.DependencyPropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.DependencyPropertyChangedEventArgs 'System.Windows.DependencyPropertyChangedEventArgs') | The e. |

<a name='M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SelectAll-System-Object,System-Windows-RoutedEventArgs-'></a>
### SelectAll(sender,e) `method`

##### Summary

Selects the all.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender. |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') | The e. |

<a name='M-EasyITSystemCenter-GlobalStyles-TextBoxBehavior-SetSelectAllTextOnFocus-System-Windows-Controls-TextBox,System-Boolean-'></a>
### SetSelectAllTextOnFocus(textBox,value) `method`

##### Summary

Xaml Extension Set Select All On Focus

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textBox | [System.Windows.Controls.TextBox](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.TextBox 'System.Windows.Controls.TextBox') |  |
| value | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-Tools-TextMarkerService'></a>
## TextMarkerService `type`

##### Namespace

EasyITSystemCenter.Tools

##### Summary

Handles the text markers for a code editor.

<a name='M-EasyITSystemCenter-Tools-TextMarkerService-Redraw-ICSharpCode-AvalonEdit-Document-ISegment-'></a>
### Redraw() `method`

##### Summary

Redraws the specified text segment.

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Tools-TextMarkerTypes'></a>
## TextMarkerTypes `type`

##### Namespace

EasyITSystemCenter.Tools

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-CircleInScrollBar'></a>
### CircleInScrollBar `constants`

##### Summary

Small circle in the scroll bar.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-DottedUnderline'></a>
### DottedUnderline `constants`

##### Summary

Dotted underline.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-LineInScrollBar'></a>
### LineInScrollBar `constants`

##### Summary

Horizontal line in the scroll bar.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-None'></a>
### None `constants`

##### Summary

Use no marker

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-NormalUnderline'></a>
### NormalUnderline `constants`

##### Summary

Normal underline.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-ScrollBarLeftTriangle'></a>
### ScrollBarLeftTriangle `constants`

##### Summary

Small triangle in the scroll bar, pointing to the left.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-ScrollBarRightTriangle'></a>
### ScrollBarRightTriangle `constants`

##### Summary

Small triangle in the scroll bar, pointing to the right.

<a name='F-EasyITSystemCenter-Tools-TextMarkerTypes-SquigglyUnderline'></a>
### SquigglyUnderline `constants`

##### Summary

Use squiggly underline marker

<a name='T-EasyITSystemCenter-GlobalClasses-TiltTargets'></a>
## TiltTargets `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Tilt Document Types Definitions

<a name='T-EasyITSystemCenter-ToolsOperations'></a>
## ToolsOperations `type`

##### Namespace

EasyITSystemCenter

##### Summary

Centralized Library With Extension Functions Of External Tools

<a name='M-EasyITSystemCenter-ToolsOperations-AvalonEditorFindText-System-String,System-Int32@,ICSharpCode-AvalonEdit-TextEditor@,System-Boolean-'></a>
### AvalonEditorFindText(searchQuery,foundedIndex,textEditor,ignoreCaseSensitive) `method`

##### Summary

Avalon editor Content Search Function With HighLight

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| searchQuery | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| foundedIndex | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') |  |
| textEditor | [ICSharpCode.AvalonEdit.TextEditor@](#T-ICSharpCode-AvalonEdit-TextEditor@ 'ICSharpCode.AvalonEdit.TextEditor@') |  |
| ignoreCaseSensitive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='M-EasyITSystemCenter-ToolsOperations-AvalonEditorReplaceText-System-String,System-String,System-Int32@,ICSharpCode-AvalonEdit-TextEditor@,System-Boolean,System-Boolean-'></a>
### AvalonEditorReplaceText(sourceString,targetString,foundedIndex,textEditor,ignoreCaseSensitive,selectedonly) `method`

##### Summary

AvalonEditor Replace Matched Strings in Editor

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| targetString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| foundedIndex | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') |  |
| textEditor | [ICSharpCode.AvalonEdit.TextEditor@](#T-ICSharpCode-AvalonEdit-TextEditor@ 'ICSharpCode.AvalonEdit.TextEditor@') |  |
| ignoreCaseSensitive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| selectedonly | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-GlobalClasses-TranslateSet'></a>
## TranslateSet `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Language definition support

<a name='T-EasyITSystemCenter-GlobalClasses-TranslationSet'></a>
## TranslationSet `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Generic Inherited Set

<a name='T-EasyITSystemCenter-GlobalStyles-TriggerTypes'></a>
## TriggerTypes `type`

##### Namespace

EasyITSystemCenter.GlobalStyles

##### Summary

Implemented Trigger Types Reactions
MouseMove Show OneTime on MouseOver
OnInit Show Forever After initialize

<a name='T-EasyITSystemCenter-Pages-UniversalCodeEditorPage'></a>
## UniversalCodeEditorPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

UniversalCodeEditorPage

<a name='M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### TemplateSelected(sender,e) `method`

##### Summary

Set Selected Template

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-UniversalCodeEditorPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### btnTheme_Click(sender,e) `method`

##### Summary

UniversalEditor Theme Controls

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='T-EasyITSystemCenter-GlobalClasses-UrlSourceTypes'></a>
## UrlSourceTypes `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Defined Url Sourvce types For Setting Corrtect UrlPath
With Requested Configurations: Auth, Message Format, etc.
Definitions:
EsbWebServer: AutoSelect ESB GloBal Web Server Url 
EicWebServer: AutoSelect EIC GloBal Web Server Url 
EicWebServerStdTableApi: Auto Select Api By Data Table Name
EicWebServerDynGetTableApi: Auto Select DynamicGetApi Url
EicWebServerDynSetTableApi: Auto Select DynamicSetApi Url
WebSavedAuthApi: Managed Acount for User Defined Url,
WebUrl: User Defined Url
TODO Pridat centralni sprava auth APIs URL, 
TODO Planovany Downloader, zasilac zprac cteni a preposilani na email,Procedury Atd
TODO: FOR TABLES ADD - MORE PREFIXES - TEST , DB TEST, CLONE TABLE, CLONE DB as PROVIDER solution 
TODO: MOVE THIS TO NEW AGENDA DEFINED API COMMUNICATION + Same FOR Request,responose format forGlobal Using
TODO: Can be used for showing JSON DATA, XML, CSV, DATA FOR DIRECT IMPORT BY DYNAMIC AGENDA - CAN GENERATE TABLE BY TABLE STRUCTURE

<a name='T-EasyITSystemCenter-GlobalClasses-UserData'></a>
## UserData `type`

##### Namespace

EasyITSystemCenter.GlobalClasses

##### Summary

Basic user data for login

<a name='T-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage'></a>
## UserFileStorage `type`

##### Namespace

EasyITSystemCenter.GlobalOperations.FileOperations

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage-SaveFile-System-Tuple{System-String,System-String}-'></a>
### SaveFile(fileList) `method`

##### Summary

Saves the file.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileList | [System.Tuple{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Tuple 'System.Tuple{System.String,System.String}') | The file list. |

<a name='M-EasyITSystemCenter-GlobalOperations-FileOperations-UserFileStorage-SaveFilesAsync-System-Collections-Generic-List{System-Tuple{System-String,System-String}}-'></a>
### SaveFilesAsync(fileList) `method`

##### Summary

Saves the files.

##### Returns

A Task.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fileList | [System.Collections.Generic.List{System.Tuple{System.String,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Tuple{System.String,System.String}}') | The file list. |

<a name='T-EasyITSystemCenter-Pages-WebBannedIpAddressListPage'></a>
## WebBannedIpAddressListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebBannedIpAddressListPage

<a name='M-EasyITSystemCenter-Pages-WebBannedIpAddressListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebCodeEditorPage'></a>
## WebCodeEditorPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebCodeEditorPage

<a name='M-EasyITSystemCenter-Pages-WebCodeEditorPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebCodeLibraryListPage'></a>
## WebCodeLibraryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebCodeLibraryListPage

<a name='M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### TemplateSelected(sender,e) `method`

##### Summary

Set Selected Template

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-WebCodeLibraryListPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### btnTheme_Click(sender,e) `method`

##### Summary

UniversalEditor Theme Controls

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='T-EasyITSystemCenter-Pages-WebConfiguratorListPage'></a>
## WebConfiguratorListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebConfiguratorListPage

<a name='M-EasyITSystemCenter-Pages-WebConfiguratorListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebConfiguratorListPage-TemplateSelected-System-Object,System-Windows-Controls-SelectionChangedEventArgs-'></a>
### TemplateSelected(sender,e) `method`

##### Summary

Set Selected Template

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.Controls.SelectionChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs') |  |

<a name='M-EasyITSystemCenter-Pages-WebConfiguratorListPage-btnTheme_Click-System-Object,System-Windows-RoutedEventArgs-'></a>
### btnTheme_Click(sender,e) `method`

##### Summary

UniversalEditor Theme Controls

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.RoutedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs') |  |

<a name='T-EasyITSystemCenter-Pages-WebCoreFileListPage'></a>
## WebCoreFileListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebCoreFileListPage

<a name='M-EasyITSystemCenter-Pages-WebCoreFileListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebDeveloperNewsListPage'></a>
## WebDeveloperNewsListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebDeveloperNewsListPage

<a name='M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-JSGetDataFromBrowser'></a>
### JSGetDataFromBrowser() `method`

##### Summary

WebView2 Global JsScript Setting Method 
Using Default: GetWebViewFromEditorData({inputHtml})

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebDeveloperNewsListPage-JSSetDataFromBrowser-System-String,System-Boolean-'></a>
### JSSetDataFromBrowser(inputHtml,isNewRequest) `method`

##### Summary

WebView2 Global JsScript Setting Method 
Using Default: SetWebViewToEditorData({inputHtml})
TODO AutoUpdate/LandServer,Load From File - Insert Metro Menu Over Script

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputHtml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| isNewRequest | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-Pages-WebDocumentationCodeLibraryListPage'></a>
## WebDocumentationCodeLibraryListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebDocumentationCodeLibraryListPage

<a name='M-EasyITSystemCenter-Pages-WebDocumentationCodeLibraryListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebDocumentationListPage'></a>
## WebDocumentationListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebDocumentationListPage

<a name='M-EasyITSystemCenter-Pages-WebDocumentationListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebGlobalPageBlockListPage'></a>
## WebGlobalPageBlockListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebGlobalPageBlockListPage

<a name='M-EasyITSystemCenter-Pages-WebGlobalPageBlockListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebGroupMenuListPage'></a>
## WebGroupMenuListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebGroupMenuListPage

<a name='M-EasyITSystemCenter-Pages-WebGroupMenuListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebMenuListPage'></a>
## WebMenuListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebMenuListPage

<a name='M-EasyITSystemCenter-Pages-WebMenuListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebMenuListPage-JSGetDataFromBrowser'></a>
### JSGetDataFromBrowser() `method`

##### Summary

WebView2 Global JsScript Setting Method 
Using Default: GetWebViewFromEditorData({inputHtml})

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-Pages-WebMenuListPage-JSSetDataFromBrowser-System-String,System-Boolean-'></a>
### JSSetDataFromBrowser(inputHtml,isNewRequest) `method`

##### Summary

WebView2 Global JsScript Setting Method 
Using Default: SetWebViewToEditorData({inputHtml})
TODO AutoUpdate/LandServer,Load From File - Insert Metro Menu Over Script

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| inputHtml | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| isNewRequest | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-EasyITSystemCenter-Pages-WebSettingListPage'></a>
## WebSettingListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebSettingListPage

<a name='M-EasyITSystemCenter-Pages-WebSettingListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller'></a>
## WebView2AutoInstaller `type`

##### Namespace

EasyITSystemCenter.SystemHelper

##### Summary

Webview2 Add Installer

<a name='M-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller-CheckAndInstallWebView'></a>
### CheckAndInstallWebView() `method`

##### Summary

Check WebView2 runtime is installed and download then install it.
This Is Startup IO.PAth Exceprion from Init WebView2 Without Object

##### Returns



##### Parameters

This method has no parameters.

<a name='M-EasyITSystemCenter-SystemHelper-WebView2AutoInstaller-InstallWebView'></a>
### InstallWebView() `method`

##### Summary

Startup Install Missing WebView2

##### Returns



##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WebVisitIpListPage'></a>
## WebVisitIpListPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WebVisitIpListPage

<a name='M-EasyITSystemCenter-Pages-WebVisitIpListPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-WelcomePage'></a>
## WelcomePage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

WelcomePage

<a name='M-EasyITSystemCenter-Pages-WelcomePage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-Pages-XamlCodeEditorPage'></a>
## XamlCodeEditorPage `type`

##### Namespace

EasyITSystemCenter.Pages

##### Summary

XamlCodeEditorPage

<a name='M-EasyITSystemCenter-Pages-XamlCodeEditorPage-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators'></a>
## XamlFormGenerators `type`

##### Namespace

EasyITSystemCenter.GlobalGenerators

##### Summary

System Online Icon Generator from custom Path Its for working with Icon over Database Dynamically

<a name='M-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators-StandardXamlFormGenerator-System-Windows-Controls-Grid,System-Data-DataTable,EasyITSystemCenter-GlobalClasses-SystemCustomPageList-'></a>
### StandardXamlFormGenerator(rootGrid,dataset,systemCustomPageList) `method`

##### Summary

Xaml Form Generator 300,*  : 15 Rows
This Is Generator For existing ListForm with Defined Grid Cool/Rows:
Form Have Basic DataView And ListForm Empty Section
Buttons,Tabs with WebView2 Window Are Defined By XAML Form
Form is Automatically Translated

##### Returns

A Grid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| rootGrid | [System.Windows.Controls.Grid](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Grid 'System.Windows.Controls.Grid') | The root grid. |
| dataset | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | The dataset. |
| systemCustomPageList | [EasyITSystemCenter.GlobalClasses.SystemCustomPageList](#T-EasyITSystemCenter-GlobalClasses-SystemCustomPageList 'EasyITSystemCenter.GlobalClasses.SystemCustomPageList') | The system custom page list. |

<a name='M-EasyITSystemCenter-GlobalGenerators-XamlFormGenerators-StandardXamlFormIODataController-System-Windows-Controls-Grid@,System-Data-DataRowView@,System-Collections-Generic-List{System-Collections-Generic-Dictionary{System-String,System-String}}@,System-Boolean,EasyITSystemCenter-GlobalClasses-SystemCustomPageList,System-Boolean,System-Boolean-'></a>
### StandardXamlFormIODataController(userForm,selectedRecord,recordForSave,dataToForm,systemCustomPageSetting,newRec,copy) `method`

##### Summary

Control The Data Comunication Between Generic Form And Selected Record

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| userForm | [System.Windows.Controls.Grid@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Controls.Grid@ 'System.Windows.Controls.Grid@') |  |
| selectedRecord | [System.Data.DataRowView@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataRowView@ 'System.Data.DataRowView@') |  |
| recordForSave | [System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Collections.Generic.Dictionary{System.String,System.String}}@') |  |
| dataToForm | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| systemCustomPageSetting | [EasyITSystemCenter.GlobalClasses.SystemCustomPageList](#T-EasyITSystemCenter-GlobalClasses-SystemCustomPageList 'EasyITSystemCenter.GlobalClasses.SystemCustomPageList') |  |
| newRec | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| copy | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
