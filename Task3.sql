select Articles.Theme, Tags.Name
from Articles 
LEFT JOIN ArticlesTags ON ArticlesTags.ArticleId = Articles.Id
LEFT JOIN Tags ON Tags.Id = ArticlesTags.TagId