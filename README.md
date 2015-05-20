# DesignPatternsFinal
So, now that you have the repository cloned on your computer here are the basic functions that you will need to use in order to reflect the changes you have made with the rest of the group.

git pull origin master: pulls any changes made from the repository on gitHub to your computer. You must do this everytime you plan on working so that your local repository is up to date with any changes any one has made.

git push origin master: pushes your changes to the repository on github so that the rest of us can see what you have done

git status: shows if you have uncommitted changes in your local repository

git add [filename]: add the file that you want to stage to commit

git commit: commits all files staged for commit

git checkout -b [branchName]: creates and switches to a branch so you can make changes without affecting the master branch

git checkout [branchName]: switches to a branch that already exists.

git merge [branchName]: merges the branch with the branch you are currently on. so usually you will want to switch to master branch, the use git merge [whatever your branch you made was]

git branch -d [branchName]: delete the branch. you never want to delete master. EVER!

thats basically all the commands you will need to use. A good website to read up on is git-scm.com They have everything you need to know about using git.