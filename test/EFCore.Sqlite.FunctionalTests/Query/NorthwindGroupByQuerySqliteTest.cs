﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore.Sqlite.Internal;

namespace Microsoft.EntityFrameworkCore.Query;

public class NorthwindGroupByQuerySqliteTest : NorthwindGroupByQueryRelationalTestBase<NorthwindQuerySqliteFixture<NoopModelCustomizer>>
{
    // ReSharper disable once UnusedParameter.Local
    public NorthwindGroupByQuerySqliteTest(NorthwindQuerySqliteFixture<NoopModelCustomizer> fixture, ITestOutputHelper testOutputHelper)
        : base(fixture)
    {
        Fixture.TestSqlLoggerFactory.Clear();
        //Fixture.TestSqlLoggerFactory.SetTestOutputHelper(testOutputHelper);
    }

    public override async Task Select_uncorrelated_collection_with_groupby_multiple_collections_work(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_uncorrelated_collection_with_groupby_multiple_collections_work(async))).Message);

    public override async Task Select_uncorrelated_collection_with_groupby_works(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_uncorrelated_collection_with_groupby_works(async))).Message);

    public override async Task Select_uncorrelated_collection_with_groupby_when_outer_is_distinct(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_uncorrelated_collection_with_groupby_when_outer_is_distinct(async))).Message);

    public override async Task AsEnumerable_in_subquery_for_GroupBy(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.AsEnumerable_in_subquery_for_GroupBy(async))).Message);

    public override async Task Complex_query_with_groupBy_in_subquery1(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Complex_query_with_groupBy_in_subquery1(async))).Message);

    public override async Task Complex_query_with_groupBy_in_subquery2(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Complex_query_with_groupBy_in_subquery2(async))).Message);

    public override async Task Complex_query_with_groupBy_in_subquery3(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Complex_query_with_groupBy_in_subquery3(async))).Message);

    public override async Task Select_nested_collection_with_groupby(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Select_nested_collection_with_groupby(async))).Message);

    public override async Task Complex_query_with_group_by_in_subquery5(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.Complex_query_with_group_by_in_subquery5(async))).Message);

    public override async Task Odata_groupby_empty_key(bool async)
        => await Assert.ThrowsAsync<NotSupportedException>(() => base.Odata_groupby_empty_key(async));

    public override async Task GroupBy_aggregate_from_multiple_query_in_same_projection(bool async)
        => Assert.Equal(
            SqliteStrings.ApplyNotSupported,
            (await Assert.ThrowsAsync<InvalidOperationException>(
                () => base.GroupBy_aggregate_from_multiple_query_in_same_projection(async))).Message);

    public override async Task GroupBy_aggregate_from_multiple_query_in_same_projection_3(bool async)
        => await Assert.ThrowsAsync<SqliteException>(() => base.GroupBy_aggregate_from_multiple_query_in_same_projection_3(async));
}
