# https://leetcode.com/problems/rising-temperature/

# Write your MySQL query statement below
select wt1.Id from Weather wt1, Weather wt2 where wt1.temperature > wt2.temperature and to_days(wt1.date)-TO_DAYS(wt2.date)=1