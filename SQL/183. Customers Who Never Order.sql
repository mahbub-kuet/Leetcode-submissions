# https://leetcode.com/problems/customers-who-never-order/

# Write your MySQL query statement below
select Name from Customers where Id not in (select CustomerId from Orders)