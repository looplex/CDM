﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

namespace Microsoft.CommonDataModel.ObjectModel.Enums
{
    public enum CdmLogCode
    {
        None,
        ErrAdapterNotFound,
        ErrDocAdapterNotFound,
        ErrDocEntityDocSavingFailure,
        ErrDocEntityReplacementFailure,
        ErrDocImportSavingFailure,
        ErrDocIsNotFolder,
        ErrDocPartitionSchemaSavingFailure,
        ErrDocSubManifestSavingFailure,
        ErrDocSymbolNotFound,
        ErrDocWrtDocNotfound,
        ErrEntityCreationFailed,
        ErrIndexFailed,
        ErrInvalidPath,
        ErrObjectWithoutOwnerFound,
        ErrPartitionFileModTimeFailure,
        ErrPathIsDuplicate,
        ErrPathNullObjectPath,
        ErrPersistAdapterNotFoundForNamespace,
        ErrPersistAdapterWriteFailure,
        ErrPersistCardinalityPropMissing,
        ErrPersistCdmEntityFetchError,
        ErrPersistClassMissing,
        ErrPersistConversionError,
        ErrPersistCsvProcessingError,
        ErrPersistDeserializeError,
        ErrPersistDocConversionFailure,
        ErrPersistModelJsonDocConversionError,
        ErrPersistDocNameLoadFailure,
        ErrPersistEntityPathNotFound,
        ErrPersistEntityAttrUnsupported,
        ErrPersistEntityDeclarationMissing,
        ErrPersistModelJsonRefEntityInvalidLocation,
        ErrPersistModelJsonEntityParsingError,
        ErrPersistFailure,
        ErrPersistFilePersistError,
        ErrPersistFilePersistFailed,
        ErrPersistFileReadFailure,
        ErrPersistSaveLinkedDocs,
        ErrPersistFileWriteFailure,
        ErrPersistModelJsonInvalidEntityPath,
        ErrPersistModelJsonInvalidExtensionTrait,
        ErrPersistJsonAttrContextConversionError,
        ErrPersistJsonDatatypeConversionError,
        ErrPersistJsonDatatypeRefConversionError,
        ErrPersistJsonImportConversionError,
        ErrPersistJsonObjectRefConversionError,
        ErrPersistModelJsonEntityAttrError,
        ErrPersistModelJsonModelIdDuplication,
        ErrPersistModelJsonModelIdNotFound,
        ErrPersistModelJsonToAttrConversionFailure,
        ErrPersistModelJsonFromAttrConversionFailure,
        ErrPersistModelJsonEntityConversionError,
        ErrPersistModelJsonEntityDeclarationConversionError,
        ErrPersistModelJsonEntityDeclarationConversionFailure,
        ErrPersistModelJsonEntityRefConversionError,
        ErrPersistModelJsonRelConversionError,
        ErrPersistNullDocName,
        ErrPersistObjectNotFound,
        ErrPersistProjInvalidOpsType,
        ErrPersistProjUnsupportedProp,
        ErrPersistSymsAdlsAdapterMissing,
        ErrPersistSymsAdlsAdapterNotMounted,
        ErrPersistSymsAttrConversionFailure,
        ErrPersistSymsAttrConversionError,
        ErrPersistSymsEntityFetchError,
        ErrPersistSymsEntityPathNull,
        ErrPersistSymsPartitionNotSupported,
        ErrPersistSymsEntityDeclConversionFailure,
        ErrPersistSymsEntityDeclConversionException,
        ErrPersistSymsMultipleOrZeroTableDefinition,
        ErrPersistSymsInvalidDbPropObject,
        ErrPersistSymsInvalidDbObject,
        ErrPersistSymsIncompatibleFileToType,
        ErrPersistSymsStorageSourceTraitError,
        ErrPersistSymsTableFormatTypeNotSupported,
        ErrPersistSymsTableInvalidDataLocation,
        ErrPersistSymsTableMissingDataLocation,
        ErrPersistSymsUnknownDataFormat,
        ErrPersistSymsUnsupportedCdmConversion,
        ErrPersistSymsUnsupportedManifest,
        ErrPersistSymsUnsupportedTableFormat,
        ErrPersistUnsupportedJsonSemVer,
        ErrPersistInvalidMaxCardinality,
        ErrPersistInvalidMinCardinality,
        ErrProjFailedToResolve,
        ErrProjRefAttrStateFailure,
        ErrProjInvalidAttrState,
        ErrProjRenameFormatIsNotSet,
        ErrProjSourceError,
        ErrProjStringError,
        ErrProjUnsupportedAttrGroups,
        ErrProjUnsupportedSource, 
        ErrRelMaxResolvedAttrReached,
        ErrResolutionFailure,
        ErrResolveEntityFailure,
        ErrResolveNewEntityNameNotSet,
        ErrResolveFolderNotFound,
        ErrResolveManifestExists,
        ErrResolveManifestFailed,
        ErrResolveReferenceFailure,
        ErrStorageAdapterNotFound,
        ErrStorageFolderNotFound,
        ErrStorageInvalidAdapterPath,
        ErrStorageInvalidPathFormat,
        ErrStorageMissingJsonConfig,
        ErrStorageMissingNamespace,
        ErrStorageMissingTypeJsonConfig,
        ErrStorageNamespaceMismatch,
        ErrStorageNamespaceNotRegistered,
        ErrStorageNullAdapter,
        ErrStorageNullAdapterConfig,
        ErrStorageNullCorpusPath,
        ErrStorageNullNamespace,
        ErrStorageObjectNodeCastFailed,
        ErrSymbolNotFound,
        ErrTraitArgumentMissing,
        ErrTraitAttrFetchError,
        ErrTraitResolutionFailure,
        ErrUnexpectedDataType,
        ErrUnexpectedType,
        ErrUnrecognizedDataType,
        ErrUnsupportedRef,
        ErrUnsupportedType,
        ErrValdnIntegrityCheckFailure,
        ErrValdnInvalidCorpusPath,
        ErrValdnInvalidDoc,
        ErrValdnInvalidMaxCardinality,
        ErrValdnInvalidMinCardinality,
        ErrValdnInvalidExpression,
        ErrValdnMissingDoc,
        ErrValdnMissingLanguageTag,
        WarnPartitionGlobAndRegexPresent,
        WarnDeprecatedResolutionGuidance,
        WarnDocChangesDiscarded,
        WarnDocImportNotLoaded,
        WarnPartitionFileFetchFailed,
        WarnLinkEntIdentArgsNotSupported,
        WarnPartitionInvalidArguments,
        WarnPersistCustomExtNotSupported,
        WarnPersistPartitionLocMissing,
        WarnPersistFileModTimeFailure,
        WarnPersistFileReadFailure,
        WarnPersistJsonSemVerInvalidFormat,
        WarnPersistJsonSemVerMandatory,
        WarnPersistModelJsonRelReadFailed,
        WarnPersistRelUndefinedSourceEntity,
        WarnPersistRelUndefinedTargetEntity,
        WarnPersistSymsEntityMissing,
        WarnPersistSymsEntitySkipped, 
        WarnPersistSymsProjNotExist,
        WarnPersistUnsupportedJsonSemVer,
        WarnPersistEntityMissing,
        WarnPersistEnumNotFound,
        WarnPersistPartitionNameNull,
        WarnProjCreateForeignKeyTraits,
        WarnProjFKWithoutSourceEntity,
        WarnProjAddArtifactAttrNotSupported,
        WarnProjRenameAttrNotSupported,
        WarnResolveAttrFailed,
        WarnResolveEntityFailed,
        WarnResolveImportFailed,
        WarnResolveObjectFailed,
        WarnResolveReferenceFailure,
        WarnStorageExpectedPathPrefix,
        WarnStorageRemoveAdapterFailed,
        WarnAnnotationTypeNotSupported,
        WarnValdnEntityNotDefined,
        WarnValdnMaxOrdinalTooHigh,
        WarnValdnPrimaryKeyMissing,
        WarnValdnOrdinalStartEndOrder,
        WarnTelemetryIngestionFailed
    }
}
