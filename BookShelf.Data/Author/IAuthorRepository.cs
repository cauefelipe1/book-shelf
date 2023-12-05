namespace BookShelf.Data.Author;

public interface IAuthorRepository
{
    AuthorDao GetAuthor(Guid authorId);

    List<AuthorDao> GetAuthorsByBook(Guid bookId);
    
    Task<Guid> CreateAuthor(AuthorDao dao);

    void UpdateAuthor(AuthorDao dao);

    void DeleteAuthor(Guid authorId); 
}