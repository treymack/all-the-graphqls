﻿using HotChocolateV12.Bands.Gql.Repositories;
using HotChocolateV12.Bands.Gql.Schema.Types;

namespace HotChocolateV12.Bands.Gql;

public class Query
{
    public Task<IQueryable<Band>> GetBandsAsync(
        [Service] IBandsRepository bandsRepository
    ) => bandsRepository.GetBands();

    public Task<Band?> GetBandAsync(
        [Service] IBandsRepository bandsRepository,
        string key
    ) => bandsRepository.GetBand(key);
}
