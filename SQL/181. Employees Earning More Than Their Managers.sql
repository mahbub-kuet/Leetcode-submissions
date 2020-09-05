# https://leetcode.com/problems/employees-earning-more-than-their-managers/

select a.name from Employee a inner join Employee b on a.managerId = b.id and a.salary>b.salary;