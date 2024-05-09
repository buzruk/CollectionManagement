﻿namespace CollectionManagement.Domain.Entities.Collections;

public sealed class Collection : Auditable
{
  public string Name { get; set; } = string.Empty;

  public string Description { get; set; } = string.Empty;

  public TopicType Topic { get; set; } = TopicType.Other;

  public string Image { get; set; } = string.Empty;

  public int UserId { get; set; }

  // public virtual User User { get; set; } = default!;
  public User? User { get; set; }

  public int CustomFieldId { get; set; }

  // public virtual List<CustomField> CustomFields { get; set; } = default!;
  public List<CustomField> CustomFields { get; set; } = [];
}
