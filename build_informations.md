# Matematico
# Informations for developers
# Please, respect the structure of code while editing

1) GENERAL INFORMATIONS

  Language: C# (.NET 4.0)
  
  Compiled in: VS 13

2) BUILD INFORMATIONS

  Lidgren.Network         - build as .dll
  
  Matematico.Comunication - build as .dll 
  
  Matematico.Game         - build as .dll
  
  Matematico.Tournaments  - build as .dll
  
  Matematico.ClientSide   - build as .exe
  
  Matematico.ServerSide   - build as .exe
  
3) DEPENDENCIES

  Matematico.ClientSide needs Matematico.Comunication.dll, Matematico.Game.dll
  
  Matematico.ServerSide needs Matematico.Comunication.dll, Matematico.Game.dll
  
  Matematico.Comunication needs Lidgren.Network.dll
  
  Matematico.Game needs -
  
  Matematico.Tournaments needs Matematico.Game.dll, Microsoft Excel object library*
  
  *e.g Microsoft Excel 15.0 Object Library in COM builds
  
4) PERMISSIONS

  Matematico.ServerSide.exe needs Administrator rights when starting NetServer
