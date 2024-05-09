﻿namespace CollectionManagement.Infrastructure.Interfaces.Likes;

public interface ILikeService
{
  Task<bool> ToggleCollection(int collectionId, CancellationToken cancellationToken = default);

  Task<bool> ToggleItem(int itemId, CancellationToken cancellationToken = default);
}

