﻿using HotChocolate.Types;
using Nikcio.UHeadless.Basics.Properties.Models;
using Nikcio.UHeadless.Core.GraphQL.Queries;
using Nikcio.UHeadless.Members.Basics.Models;
using Nikcio.UHeadless.Members.Queries;

namespace Nikcio.UHeadless.Members.Basics.Queries;

/// <summary>
/// The member queries
/// </summary>
[ExtendObjectType(typeof(Query))]
public class BasicMemberQuery : MemberQuery<BasicMember, BasicProperty>
{
}
