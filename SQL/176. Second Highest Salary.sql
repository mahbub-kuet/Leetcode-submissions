# https://leetcode.com/problems/second-highest-salary/
# Write your MySQL query statement below
select max(salary) from Employee where salary not in (select max(salary) from Employee)