﻿using Moq;
using Xunit;

namespace Cosmonaut.Tests
{
    public class CosmosStoreTests
    {
        [Fact]
        public void DatabaseAndCollectionReturnSelfLink()
        {
            // Arrange
            var databaseName = "dbName";
            var collectionName = "collName";
            var documentId = "documentId";
            var expectedSelfLink = $"dbs/{databaseName}/colls/{collectionName}/docs/{documentId}/";

            // Act
            var selfLink = new CosmosDocumentProcessor<Dummy>().GetDocumentSelfLink(databaseName,collectionName,documentId);

            // Assert
            Assert.Equal(expectedSelfLink, selfLink);
        }
    }
}