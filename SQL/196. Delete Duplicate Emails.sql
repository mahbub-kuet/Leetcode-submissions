# https://leetcode.com/problems/delete-duplicate-emails/

delete from Person where Id not in (select a.Id from (select min(Id) as Id from Person group by Email)as a)