﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v5.10.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SD.LLBLGen.Pro.QuerySpec;
using Data.HelperClasses;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.LinqSupportClasses.DTOProjectionHelpers;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Views.Persistence
{
	///<summary>class to define custom where/orderby clauses to be used in the linq / query spec query projection</summary>
	public partial class UserTravelProjectionParams
	{
		///<summary>class to define custom where/orderby clauses to be used in the linq / query spec query projection</summary>
		public partial class U_TravelsProjectionParams_Clauses
		{
			/// <summary>QuerySpec specific. Appends a new OrderBy clause for the Travels embedded set.</summary>
			/// <param name="clauseToAdd">the clause to add</param>
			public void AppendQSOrderBy(ISortClause clauseToAdd) => this.QSOrderByClauses.Add(clauseToAdd);
			/// <summary>Linq specific. Appends a new OrderBy clause for the Travels embedded set.</summary>
			/// <param name="orderByClause">The order by clause to use</param>
			/// <param name="descending">if true, the order by will be descending, otherwise ascending (default)</param>
			/// <typeparam name="TField">The type of the field to sort by</typeparam>
			public void AppendLinqOrderBy<TField>(System.Linq.Expressions.Expression<Func<Data.EntityClasses.TravelEntity, TField>> orderByClause, bool descending = false) => this.LinqOrderByClauses.Add(new SD.LLBLGen.Pro.ORMSupportClasses.ValuePair<System.Linq.Expressions.Expression, bool>((System.Linq.Expressions.Expression)orderByClause, descending));
			internal List<SD.LLBLGen.Pro.ORMSupportClasses.ValuePair<System.Linq.Expressions.Expression, bool>> LinqOrderByClauses { get; } = new List<SD.LLBLGen.Pro.ORMSupportClasses.ValuePair<System.Linq.Expressions.Expression, bool>>();
			internal List<ISortClause> QSOrderByClauses { get; set; } = new List<ISortClause>();
			/// <summary>Linq specific. Custom where clause to be used for when the Travels embedded set is fetched</summary>
			public System.Linq.Expressions.Expression<Func<Data.EntityClasses.TravelEntity, bool>> LinqWhereClause { get; set; }
			/// <summary>QuerySpec specific. Custom where clause to be used for when the Travels embedded set is fetched</summary>
			public IPredicate QSWhereClause { get; set; }
		}

		/// <summary>Projection parameters to configure where / orderby clauses for the nested member 'Travels'</summary>
		public U_TravelsProjectionParams_Clauses TravelsProjectionParams { get; } = new U_TravelsProjectionParams_Clauses();
	}

	/// <summary>Static class for (extension) methods for fetching and projecting instances of Views.DtoClasses.UserTravel from the entity model.</summary>
	public static partial class UserTravelPersistence
	{
		private static readonly System.Linq.Expressions.Expression<Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel>> _projectorExpression = CreateProjectionFunc();
		private static readonly Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel> _compiledProjector = CreateProjectionFunc().Compile();
		/// <summary>Linq specific partial method for obtaining projection adjustments for the projection method <see cref="ProjectToUserTravel(System.Linq.IQueryable{Data.EntityClasses.UserEntity})"/></summary>
		/// <param name="projectionAdjustments">Set this argument in an implementation of this partial method to a projection lambda similar to the generated projection in <see cref="CreateProjectionFunc"/></param>
		/// <remarks>Linq specific</remarks>
		static partial void GetAdjustmentsForProjectToUserTravel(ref System.Linq.Expressions.Expression<Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel>> projectionAdjustments);
		/// <summary>QuerySpec specific partial method for obtaining projection adjustments for the projection method <see cref="ProjectToUserTravel(EntityQuery{Data.EntityClasses.UserEntity}, Data.FactoryClasses.QueryFactory)"/></summary>
		/// <param name="projectionAdjustments">Set this argument in an implementation of this partial method to a projection lambda similar to the generated projection in <see cref="ProjectToUserTravel(EntityQuery{Data.EntityClasses.UserEntity}, Data.FactoryClasses.QueryFactory)"/></param>
		/// <remarks>QuerySpec specific</remarks>
		static partial void GetAdjustmentsForProjectToUserTravelQs(ref System.Linq.Expressions.Expression<Func<Views.DtoClasses.UserTravel>> projectionAdjustments);
	
		/// <summary>Empty static ctor for triggering initialization of static members in a thread-safe manner</summary>
		static UserTravelPersistence() { }
	
		/// <summary>Extension method which produces a projection to Views.DtoClasses.UserTravel which instances are projected from the results of the specified baseQuery, which returns Data.EntityClasses.UserEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <returns>IQueryable to retrieve Views.DtoClasses.UserTravel instances</returns>
		public static IQueryable<Views.DtoClasses.UserTravel> ProjectToUserTravel(this IQueryable<Data.EntityClasses.UserEntity> baseQuery) => ProjectToUserTravel(baseQuery, null);
		/// <summary>Extension method which produces a projection to Views.DtoClasses.UserTravel which instances are projected from the results of the specified baseQuery, which returns Data.EntityClasses.UserEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <param name="projectionParams">The optional projection parameters with optional where/orderby clauses for nested sets in the projection</param>
		/// <returns>IQueryable to retrieve Views.DtoClasses.UserTravel instances</returns>
		public static IQueryable<Views.DtoClasses.UserTravel> ProjectToUserTravel(this IQueryable<Data.EntityClasses.UserEntity> baseQuery, UserTravelProjectionParams projectionParams)
		{
			if(projectionParams == null)
			{
				return baseQuery.Select(_projectorExpression);
			}
			return baseQuery.Select(CreateProjectionFunc(projectionParams));
		}

		/// <summary>Extension method which produces a projection to Views.DtoClasses.UserTravel which instances are projected from the results of the specified baseQuery using QuerySpec, which returns Data.EntityClasses.UserEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <param name="qf">The query factory used to create baseQuery.</param>
		/// <returns>DynamicQuery to retrieve Views.DtoClasses.UserTravel instances</returns>
		public static DynamicQuery<Views.DtoClasses.UserTravel> ProjectToUserTravel(this EntityQuery<Data.EntityClasses.UserEntity> baseQuery, Data.FactoryClasses.QueryFactory qf) => ProjectToUserTravel(baseQuery, qf, null);
		/// <summary>Extension method which produces a projection to Views.DtoClasses.UserTravel which instances are projected from the results of the specified baseQuery using QuerySpec, which returns Data.EntityClasses.UserEntity instances, the root entity of the derived element returned by this query.</summary>
		/// <param name="baseQuery">The base query to project the derived element instances from.</param>
		/// <param name="qf">The query factory used to create baseQuery.</param>
		/// <param name="projectionParams">The optional projection parameters with optional where/orderby clauses for nested sets in the projection</param>
		/// <returns>DynamicQuery to retrieve Views.DtoClasses.UserTravel instances</returns>
		public static DynamicQuery<Views.DtoClasses.UserTravel> ProjectToUserTravel(this EntityQuery<Data.EntityClasses.UserEntity> baseQuery, Data.FactoryClasses.QueryFactory qf, UserTravelProjectionParams projectionParams=null)
		{
			System.Linq.Expressions.Expression<Func<Views.DtoClasses.UserTravel>> projectionAdjustments = null;
			GetAdjustmentsForProjectToUserTravelQs(ref projectionAdjustments);
			return qf.Create()
				.From(baseQuery.Select(Projection.Full).As("__BQ"))
				.Select(LinqUtils.MergeProjectionAdjustmentsIntoProjection(() => new Views.DtoClasses.UserTravel()
				{
					FirstName = UserFields.FirstName.Source("__BQ").ToValue<System.String>(),
					Id = UserFields.Id.Source("__BQ").ToValue<System.Int32>(),
					LastName = UserFields.LastName.Source("__BQ").ToValue<System.String>(),
					Password = UserFields.Password.Source("__BQ").ToValue<System.String>(),
					Travels = (List<Views.DtoClasses.UserTravelTypes.Travel>)qf.Travel.TargetAs("__L1_0")
						.CorrelatedOver(UserFields.Id.Source("__BQ").Equal(TravelFields.UserId.Source("__L1_0")))
						.From(QueryTarget
							.InnerJoin(qf.Location.As("__L1_1")).On(TravelFields.LocationId.Source("__L1_0").Equal(LocationFields.Id.Source("__L1_1"))))
						.Where(projectionParams==null ? null : GeneralUtils.SetAliasOnPredicate(projectionParams.TravelsProjectionParams.QSWhereClause, "__L1_0"))
						.OrderBy(projectionParams==null ? null : GeneralUtils.SetAliasOnSortClauses(projectionParams.TravelsProjectionParams.QSOrderByClauses, "__L1_0"))
						.Select(() => new Views.DtoClasses.UserTravelTypes.Travel()
						{
							Location = new Views.DtoClasses.UserTravelTypes.TravelTypes.Location()
								{
									Country = LocationFields.Country.Source("__L1_1").ToValue<System.String>(),
									Id = LocationFields.Id.Source("__L1_1").ToValue<System.Int32>(),
									Name = LocationFields.Name.Source("__L1_1").ToValue<System.String>(),
								},
						}).ToResultset(),
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegionQS_UserTravel 
	// __LLBLGENPRO_USER_CODE_REGION_END 
				}, projectionAdjustments, false));
		}

		/// <summary>Extension method which produces a projection to Views.DtoClasses.UserTravel which instances are projected from the Data.EntityClasses.UserEntity entity instance specified, the root entity of the derived element returned by this method.</summary>
		/// <param name="entity">The entity to project from.</param>
		/// <returns>Data.EntityClasses.UserEntity instance created from the specified entity instance</returns>
		public static Views.DtoClasses.UserTravel ProjectToUserTravel(this Data.EntityClasses.UserEntity entity)
		{
			return _compiledProjector(entity);
		}

		private static System.Linq.Expressions.Expression<Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel>> CreateProjectionFunc(UserTravelProjectionParams projectionParams=null)
		{
			System.Linq.Expressions.Expression<Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel>> mainProjection = p__0 => new Views.DtoClasses.UserTravel()
			{
				FirstName = p__0.FirstName,
				Id = p__0.Id,
				LastName = p__0.LastName,
				Password = p__0.Password,
				Travels = p__0.Travels.AsQueryable().OptionalWhere(projectionParams.TravelsProjectionParams.LinqWhereClause).OptionalOrderBy(projectionParams.TravelsProjectionParams.LinqOrderByClauses).Select(p__1 => new Views.DtoClasses.UserTravelTypes.Travel()
				{
					Location = new Views.DtoClasses.UserTravelTypes.TravelTypes.Location()
					{
						Country = p__1.Location.Country,
						Id = p__1.Location.Id,
						Name = p__1.Location.Name,
					},
				}).ToList(),
	// __LLBLGENPRO_USER_CODE_REGION_START ProjectionRegion_UserTravel 
	// __LLBLGENPRO_USER_CODE_REGION_END 
			};
			System.Linq.Expressions.Expression<Func<Data.EntityClasses.UserEntity, Views.DtoClasses.UserTravel>> projectionAdjustments = null;
			GetAdjustmentsForProjectToUserTravel(ref projectionAdjustments);
			return LinqUtils.MergeProjectionAdjustmentsIntoProjection(mainProjection, projectionAdjustments, true);
		}
	}
}


