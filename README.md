# protobuf-net-cross-usage

This is an example project for using protobuf-net using "code-first" method as a server/service
it will generate .proto files at start
so it can use in client side

at the client, you can use that .proto file to comunicate with server

installed library
- Server
  - Grpc.AspNetCore
  - Grpc.AspNetCore.Web
  - protobuf-net
  - protobuf-net.Grpc
  - protobuf-net.Grpc.AspNetCore
  - protobuf-net.Grpc.Reflection -> for .proto file generator
  - protobuf-net.BuildTools
  - System.ServiceModel.Primitives -> for declare service contracts
  - System.ServiceModel.Http -> optional
  
- Client
  - Google.Protobuf
  - Grpc.Net.Client
  - Grpc.Tools

package name of .proto files and namespace of proto model in server must be the same
