using TriangleDocker.dataBasa;

namespace TriangleDocker.Models.graphQL
{
    public class Queries
    {
        public IQueryable<Author> Read([Service] AppDBcontent ctx) => ctx.Authors;
    }
}
