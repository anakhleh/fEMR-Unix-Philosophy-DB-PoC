using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleManagerService.DTO;
using Org.OpenAPITools.Model;

namespace SimpleManagerService.Managers{

    public class SimpleManagerFunctionalCore{

        public List<SubjectWithSubjectInfo> CombineSubjectAndSubjectInfo(
            List<SubjectModelApiGetList> subjects,
            List<SubjectInfoModelApiGetList> subjectInfos
        ){
            List<SubjectWithSubjectInfo> subjectWithSubjectInfos = new List<SubjectWithSubjectInfo>();

            foreach(SubjectModelApiGetList s in subjects){
                if(subjectInfos.Where(subjectInfo => subjectInfo.SubjectId == s.Id).ToList().Count > 0){
                    var relatedSubjectInfos = subjectInfos.Where(subjectInfo => subjectInfo.SubjectId == s.Id).ToList();
                    string concatenatedInfos = "";
                    relatedSubjectInfos.ForEach(subjectInfo => {
                        concatenatedInfos += subjectInfo.Info + " | ";
                    });
                    subjectWithSubjectInfos.Add(new SubjectWithSubjectInfo{
                        id = s.Id,
                        name = s.Name,
                        info = concatenatedInfos
                    });
                }
            }

            return subjectWithSubjectInfos;
        }
    }
}