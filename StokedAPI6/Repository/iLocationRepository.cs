﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StokedAPI6.Models;

namespace StokedAPI6.Repository
{
    public interface iLocationRepository
    {
        IEnumerable<LocationModel> GetAll();
        LocationModel Find(int Id);
        void DeleteLocation(int Id);
        void InsertOrUpdate(string CurrentUserId, LocationModel location);

    }
}