function validateHTTPRequest(obj){
    const allowedMethods = ['GET', 'POST', 'DELETE', 'CONNECT'];
    const allowedVersions = ['HTTP/0.9', ', HTTP/1.0', 'HTTP/1.1', 'HTTP/2.0'];
    const forbiddenMessageSymbols = ['<', '>', '\\', '&', '\'', '\"'];
    const uriValidationPattern = /(^[\w.+]+$)/;
    
    if (!allowedMethods.includes(obj.method) || !obj.hasOwnProperty('method')) {
        throw new Error('Invalid request header: Invalid Method');
    }
    
    if(obj.uri == '' || !obj.hasOwnProperty('uri') || !uriValidationPattern.test(obj.uri)){
        if (obj.uri != '*') {
        throw new Error('Invalid request header: Invalid URI');            
        }
    }

    if(!allowedVersions.includes(obj.version) || !obj.hasOwnProperty('version')){
        throw new Error('Invalid request header: Invalid Version');
    }

    if(!obj.hasOwnProperty('message')){
        throw new Error('Invalid request header: Invalid Message');
    }

   forbiddenMessageSymbols.forEach(s => {
       if (obj.message.includes(s)) {
        throw new Error('Invalid request header: Invalid Message');
       }
   })

    return obj;
}

   console.log(validateHTTPRequest({
    method: 'GET',
    uri: '*',
    version: 'HTTP/1.1',
    message: ''
  }
  ));