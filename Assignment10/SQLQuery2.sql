create database Assignment10Db

use Assignment10Db

create table Articles(
ArticleId int primary key,
Title nvarchar(255),
Content nvarchar(max),
PublishDate datetime)

insert into Articles (ArticleId, Title, Content, PublishDate)
values (11, 'Introduction to ASP.NET', 'ASP.NET is a framework...', '2023-08-25');
insert into Articles (ArticleId, Title, Content, PublishDate)
values (12, 'Getting Started with SQL', 'SQL is a powerful...', '2020-07-05');
insert into Articles (ArticleId, Title, Content, PublishDate)
values(13, 'Web Design Best Practices', 'Designing a user-friendly...', '2019-06-06');
insert into Articles (ArticleId, Title, Content, PublishDate)
values (14, 'JavaScript Fundamentals', 'JavaScript is a scripting...', '2017-05-15');

select * from Articles



