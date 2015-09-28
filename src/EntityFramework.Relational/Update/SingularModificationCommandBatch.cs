// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.Storage;

namespace Microsoft.Data.Entity.Update
{
    public class SingularModificationCommandBatch : AffectedCountModificationCommandBatch
    {
        public SingularModificationCommandBatch(
            [NotNull] IRelationalCommandBuilderFactory commandBuilderFactory,
            [NotNull] IUpdateSqlGenerator sqlGenerator)
            : base(commandBuilderFactory, sqlGenerator)
        {
        }

        protected override bool CanAddCommand(ModificationCommand modificationCommand)
            => ModificationCommands.Count == 0;

        protected override bool IsCommandTextValid()
            => true;
    }
}
