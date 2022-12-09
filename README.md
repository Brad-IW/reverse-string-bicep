[![Build Status](https://dev.azure.com/bradpodmore2001/String%20Reverse%20API/_apis/build/status/Brad-IW.reverse-string-bicep?branchName=main)](https://dev.azure.com/bradpodmore2001/String%20Reverse%20API/_build/latest?definitionId=2&branchName=main)

Available at this address: https://reversestring.azurewebsites.net/api/ReverseString
Provide ?text= to the query to reverse a string. 

Installation guide:
create a fork of this repo or clone it into your own repo

open azure devops
create new project
 - name

project settings 
service connections
create service connection
azure resource manager
next
service principal (automatic)
next
sign into azure account
give service connection name (rember this)
 - leave resource group blank
ensure grant access to all pipelines checked
save

optional add agent (if an agent is already set up ignore this)
project settings
agent pools
default
new agent
download the agent too whatever system you are using (win, mac, linux)
extract this to a folder
follow these instructions to setup an agent
https://learn.microsoft.com/en-us/azure/devops/pipelines/agents/v2-windows?view=azure-devops

go to pipelines, then pipelines
create pipeline
select github
select the cloned/forked repo
approve and install azure pipelines to github
in parameters section set default values:
    azureServiceconnection -> name of service connection from previous step
    resourceGroupName -> change this to the name you would like to use for your resource group (can be left the same)
    location -> azure server location for resources
    appName -> The name of the app to be used, must be unique
    
save and run, save and run
if needed
 - hit authorize resources,
 - permit pipeline to run