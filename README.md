# csharp-api-auth

## Before running

- You need to create a couple of files:
```
touch appsettings.json
touch appsettings.Development.json
```
- You then need to add the following contents to both files:  
```
{
  "AppSettings": {
    "Token": "any secret passphrase goes here but make sure that the passphrase is really big in size"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*"
}

```
## Packages

install-package bcrypt.net-core 

