using GraphQL.Types;

namespace GraphQLProject.Type
{
    public class ReservationInputType : InputObjectGraphType
    {
        public ReservationInputType()
        {
            Field<IntGraphType>("id");
            Field<StringGraphType>("customerName");
            Field<StringGraphType>("email");
            Field<StringGraphType>("phoneNumber");
            Field<IntGraphType>("partySize");
            Field<StringGraphType>("specialRequest");
            Field<DateGraphType>("reservationDate");

        }
    }
}
