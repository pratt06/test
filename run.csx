using System.Net;
public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log) {
  return req.CreateResponse(HttpStatusCode.OK, \"Hello from MyFunction\");
}
