// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Npgsql;
using System.Collections.Generic;
using ValueTypeTests;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertGradeOperation907442297
    public class UpsertGradeOperation907442297 : Marten.Internal.Operations.StorageOperation<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly ValueTypeTests.Grade _document;
        private readonly ValueTypeTests.GradeId _id;
        private readonly System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertGradeOperation907442297(ValueTypeTests.Grade document, ValueTypeTests.GradeId id, System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select strong_typed.mt_upsert_grade(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, ValueTypeTests.Grade document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id.Value.Value;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }

    }

    // END: UpsertGradeOperation907442297
    
    
    // START: InsertGradeOperation907442297
    public class InsertGradeOperation907442297 : Marten.Internal.Operations.StorageOperation<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly ValueTypeTests.Grade _document;
        private readonly ValueTypeTests.GradeId _id;
        private readonly System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertGradeOperation907442297(ValueTypeTests.Grade document, ValueTypeTests.GradeId id, System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select strong_typed.mt_insert_grade(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, ValueTypeTests.Grade document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id.Value.Value;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }

    }

    // END: InsertGradeOperation907442297
    
    
    // START: UpdateGradeOperation907442297
    public class UpdateGradeOperation907442297 : Marten.Internal.Operations.StorageOperation<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly ValueTypeTests.Grade _document;
        private readonly ValueTypeTests.GradeId _id;
        private readonly System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateGradeOperation907442297(ValueTypeTests.Grade document, ValueTypeTests.GradeId id, System.Collections.Generic.Dictionary<ValueTypeTests.GradeId, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select strong_typed.mt_update_grade(?, ?, ?, ?)";


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, ValueTypeTests.Grade document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;

            if (document.Id != null)
            {
                parameters[2].Value = document.Id.Value.Value;
            }

            else
            {
                parameters[2].Value = System.DBNull.Value;
            }

            setVersionParameter(parameters[3]);
        }

    }

    // END: UpdateGradeOperation907442297
    
    
    // START: QueryOnlyGradeSelector907442297
    public class QueryOnlyGradeSelector907442297 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<ValueTypeTests.Grade>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyGradeSelector907442297(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public ValueTypeTests.Grade Resolve(System.Data.Common.DbDataReader reader)
        {

            ValueTypeTests.Grade document;
            document = _serializer.FromJson<ValueTypeTests.Grade>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<ValueTypeTests.Grade> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            ValueTypeTests.Grade document;
            document = await _serializer.FromJsonAsync<ValueTypeTests.Grade>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyGradeSelector907442297
    
    
    // START: LightweightGradeSelector907442297
    public class LightweightGradeSelector907442297 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<ValueTypeTests.Grade, ValueTypeTests.GradeId>, Marten.Linq.Selectors.ISelector<ValueTypeTests.Grade>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightGradeSelector907442297(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public ValueTypeTests.Grade Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = ValueTypeTests.GradeId.From(reader.GetFieldValue<System.Guid>(0));

            ValueTypeTests.Grade document;
            document = _serializer.FromJson<ValueTypeTests.Grade>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<ValueTypeTests.Grade> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = ValueTypeTests.GradeId.From(await reader.GetFieldValueAsync<System.Guid>(0, token));

            ValueTypeTests.Grade document;
            document = await _serializer.FromJsonAsync<ValueTypeTests.Grade>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightGradeSelector907442297
    
    
    // START: IdentityMapGradeSelector907442297
    public class IdentityMapGradeSelector907442297 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<ValueTypeTests.Grade, ValueTypeTests.GradeId>, Marten.Linq.Selectors.ISelector<ValueTypeTests.Grade>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapGradeSelector907442297(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public ValueTypeTests.Grade Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = ValueTypeTests.GradeId.From(reader.GetFieldValue<System.Guid>(0));
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            ValueTypeTests.Grade document;
            document = _serializer.FromJson<ValueTypeTests.Grade>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<ValueTypeTests.Grade> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = ValueTypeTests.GradeId.From(await reader.GetFieldValueAsync<System.Guid>(0, token));
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            ValueTypeTests.Grade document;
            document = await _serializer.FromJsonAsync<ValueTypeTests.Grade>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapGradeSelector907442297
    
    
    // START: DirtyTrackingGradeSelector907442297
    public class DirtyTrackingGradeSelector907442297 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<ValueTypeTests.Grade, ValueTypeTests.GradeId>, Marten.Linq.Selectors.ISelector<ValueTypeTests.Grade>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingGradeSelector907442297(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public ValueTypeTests.Grade Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = ValueTypeTests.GradeId.From(reader.GetFieldValue<System.Guid>(0));
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            ValueTypeTests.Grade document;
            document = _serializer.FromJson<ValueTypeTests.Grade>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<ValueTypeTests.Grade> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = ValueTypeTests.GradeId.From(await reader.GetFieldValueAsync<System.Guid>(0, token));
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            ValueTypeTests.Grade document;
            document = await _serializer.FromJsonAsync<ValueTypeTests.Grade>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingGradeSelector907442297
    
    
    // START: QueryOnlyGradeDocumentStorage907442297
    public class QueryOnlyGradeDocumentStorage907442297 : Marten.Internal.Storage.QueryOnlyDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyGradeDocumentStorage907442297(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override ValueTypeTests.GradeId AssignIdentity(ValueTypeTests.Grade document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == null) _setter(document, ValueTypeTests.GradeId.From(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid()));
            return document.Id.Value;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override ValueTypeTests.GradeId Identity(ValueTypeTests.Grade document)
        {
            return document.Id.Value;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyGradeSelector907442297(session, _document);
        }


        public override object RawIdentityValue(ValueTypeTests.GradeId id)
        {
            return id.Value;
        }

    }

    // END: QueryOnlyGradeDocumentStorage907442297
    
    
    // START: LightweightGradeDocumentStorage907442297
    public class LightweightGradeDocumentStorage907442297 : Marten.Internal.Storage.LightweightDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightGradeDocumentStorage907442297(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override ValueTypeTests.GradeId AssignIdentity(ValueTypeTests.Grade document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == null) _setter(document, ValueTypeTests.GradeId.From(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid()));
            return document.Id.Value;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override ValueTypeTests.GradeId Identity(ValueTypeTests.Grade document)
        {
            return document.Id.Value;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightGradeSelector907442297(session, _document);
        }


        public override object RawIdentityValue(ValueTypeTests.GradeId id)
        {
            return id.Value;
        }

    }

    // END: LightweightGradeDocumentStorage907442297
    
    
    // START: IdentityMapGradeDocumentStorage907442297
    public class IdentityMapGradeDocumentStorage907442297 : Marten.Internal.Storage.IdentityMapDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapGradeDocumentStorage907442297(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override ValueTypeTests.GradeId AssignIdentity(ValueTypeTests.Grade document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == null) _setter(document, ValueTypeTests.GradeId.From(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid()));
            return document.Id.Value;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override ValueTypeTests.GradeId Identity(ValueTypeTests.Grade document)
        {
            return document.Id.Value;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapGradeSelector907442297(session, _document);
        }


        public override object RawIdentityValue(ValueTypeTests.GradeId id)
        {
            return id.Value;
        }

    }

    // END: IdentityMapGradeDocumentStorage907442297
    
    
    // START: DirtyTrackingGradeDocumentStorage907442297
    public class DirtyTrackingGradeDocumentStorage907442297 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingGradeDocumentStorage907442297(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override ValueTypeTests.GradeId AssignIdentity(ValueTypeTests.Grade document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == null) _setter(document, ValueTypeTests.GradeId.From(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid()));
            return document.Id.Value;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertGradeOperation907442297
            (
                document, Identity(document),
                session.Versions.ForType<ValueTypeTests.Grade, ValueTypeTests.GradeId>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(ValueTypeTests.Grade document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override ValueTypeTests.GradeId Identity(ValueTypeTests.Grade document)
        {
            return document.Id.Value;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingGradeSelector907442297(session, _document);
        }


        public override object RawIdentityValue(ValueTypeTests.GradeId id)
        {
            return id.Value;
        }

    }

    // END: DirtyTrackingGradeDocumentStorage907442297
    
    
    // START: GradeBulkLoader907442297
    public class GradeBulkLoader907442297 : Marten.Internal.CodeGeneration.BulkLoader<ValueTypeTests.Grade, ValueTypeTests.GradeId>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId> _storage;

        public GradeBulkLoader907442297(Marten.Internal.Storage.IDocumentStorage<ValueTypeTests.Grade, ValueTypeTests.GradeId> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY strong_typed.mt_doc_grade(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_grade_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into strong_typed.mt_doc_grade (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_grade_temp.\"id\", mt_doc_grade_temp.\"data\", mt_doc_grade_temp.\"mt_version\", mt_doc_grade_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_grade_temp left join strong_typed.mt_doc_grade on mt_doc_grade_temp.id = strong_typed.mt_doc_grade.id where strong_typed.mt_doc_grade.id is null)";

        public const string OVERWRITE_SQL = "update strong_typed.mt_doc_grade target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_grade_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_grade_temp as select * from strong_typed.mt_doc_grade limit 0";


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, ValueTypeTests.Grade document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id.Value.Value, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, ValueTypeTests.Grade document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id.Value.Value, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }

    }

    // END: GradeBulkLoader907442297
    
    
    // START: GradeProvider907442297
    public class GradeProvider907442297 : Marten.Internal.Storage.DocumentProvider<ValueTypeTests.Grade>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public GradeProvider907442297(Marten.Schema.DocumentMapping mapping) : base(new GradeBulkLoader907442297(new QueryOnlyGradeDocumentStorage907442297(mapping)), new QueryOnlyGradeDocumentStorage907442297(mapping), new LightweightGradeDocumentStorage907442297(mapping), new IdentityMapGradeDocumentStorage907442297(mapping), new DirtyTrackingGradeDocumentStorage907442297(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: GradeProvider907442297
    
    
}

