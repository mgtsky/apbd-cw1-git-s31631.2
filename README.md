This project demonstrates Git operations for APBD course.
# APBD Git Tutorial 1

## 1. When does Git perform a fast-forward and when is a merge commit created?

Fast-forward happens when the main branch has no new commits after a branch was created. Git simply moves the branch pointer forward to the newest commit.

A merge commit is created when both branches have new commits and Git must combine their histories.

## 2. What is the practical difference between merge and rebase?

Merge keeps the full branch history and creates a merge commit.

Rebase rewrites history by placing commits on top of another branch, creating a clean linear history.

## 3. How was the conflict resolved in your repository?

The conflict occurred in `Program.cs` when the same line was modified in both branches.  
It was resolved manually by editing the file, choosing the correct message, removing the conflict markers, and committing the resolved version.
