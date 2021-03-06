using System;

namespace NServiceBus.SagaPersisters.NHibernate.AutoPersistence.Attributes
{
    public class TableNameAttribute : Attribute
    {
        public string TableName { get; private set; }

        public TableNameAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}