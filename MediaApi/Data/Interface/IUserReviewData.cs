using MediaApi.Models;
using System;
using System.Collections.Generic;

namespace MediaApi.Data.Interface
{
    public interface IUserReviewData
    {
        List<UserReview> Get();

        UserReview Get(Guid id);

        UserReview Add(UserReview i);

        UserReview Update(UserReview i);

        Boolean Delete(Guid id);
    }
}
