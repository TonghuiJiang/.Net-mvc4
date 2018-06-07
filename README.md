# .Net-mvc4
This is an ASP.NET practice project

When I eable migrations at the begining of section 3, I found a bug which had been commited.
What I did is reset the repository to a previous commit
```
git reset --hard <Commit-Name>
```
After that, I tried to enable migrations again, but I cannot push to the github.
I used the command below to make it:
```
git push origin master --force
```
It is surely not the best solution but I successfully commited and pushed to github and covered the wrong commit.
There should be some better way to roll back!!!
 
