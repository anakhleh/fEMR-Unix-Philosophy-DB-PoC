using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleManagerService.Managers;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;

namespace SimpleManagerService.Managers{

    public class SimpleManager{

        // public class __SubjectModelApiApi : SubjectModelApiApi{
            
        // }

        private readonly SimpleManagerFunctionalCore __SimpleManagerFunctionalCore;
        private readonly SubjectModelApiApi __SubjectModelApiApi = new SubjectModelApiApi();
        private readonly SubjectInfoModelApiApi __SubjectInfoModelApiApi = new SubjectInfoModelApiApi();

        public SimpleManager(SimpleManagerFunctionalCore s){
            __SimpleManagerFunctionalCore = s;
        }

        public Object ShowAll(){
            var subjectModelApiGetList = __SubjectModelApiApi.SubjectGet().Result;
            var subjectInfoModelApiGetList = __SubjectInfoModelApiApi.SubjectinfoGet().Result;
            return __SimpleManagerFunctionalCore.CombineSubjectAndSubjectInfo(
                subjectModelApiGetList,
                subjectInfoModelApiGetList
            );
        }
        
    }
    
}