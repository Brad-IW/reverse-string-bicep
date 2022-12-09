# Reverse String API

[![Build Status](https://dev.azure.com/bradpodmore2001/String%20Reverse%20API/_apis/build/status/Brad-IW.reverse-string-bicep?branchName=main)](https://dev.azure.com/bradpodmore2001/String%20Reverse%20API/_build/latest?definitionId=2&branchName=main)

## Installation Guide with DevOps

1. Fork this repo or clone it into your own personal repo.

  To use the CI/CD provided as a part of this repo you will need to create your own repo from which Azure DevOps can pull from.

2. Open Azure DevOps and click create a new project. 
3. Give the project a name and press create.

  To use this repo we need to have a connection to Azure Resource Manager which we will now create.
  
4. Click project settings on the bottom of the left panel.
5. Find and press the service connections button.
6. Click create service connection.
7. Choose Azure Resource Manager and press next.
8. Keep the default option (service principal (automatic)) and click next.
9. Sign into the Azure account you want to upload the API to.
10. Give the service a name, keep this name in mind as we will be using it later.
  Make sure to leave the resource group option blank.
  Also ensure that the Grant access permission to all pipelines option has been set.
11. Click save.

  Now that the ARM has been set up we can move on to setting up a worker agent. This is an optional step depending on how your Azure DevOps is set up. If you already have an agent you can safely ignore this step, otherwise follow along to install an agent onto one of your devices.

  

## Test Plan


// remove me

Available at this address: https://reversestring.azurewebsites.net/api/ReverseString
Provide ?text= to the query to reverse a string. 

Installation guide:
create a fork of this repo or clone it into your own repo


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