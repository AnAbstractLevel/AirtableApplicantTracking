import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

/*
  Generated class for the RestAPISErvice provider.

  See https://angular.io/docs/ts/latest/guide/dependency-injection.html
  for more info on providers and Angular 2 DI.
*/
@Injectable()
export class RestAPIService {

    apiUrl = 'http://localhost:64110/api';


    constructor(public http: Http) {
      console.log('Hello RestAPIService Provider');
    }

    
      
      
      
      
      
    public applicants: any[];
    getApplicants() {

        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Applicants?expand=all')
                .map(res => res.json())
                .subscribe(data => {
                    this.applicants = data;
                    resolve(this.applicants);
                });
        });
    }

    public applicant: any[];
    getApplicant(applicant: any) {
        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Applicants?expand=all&applicantId=' + applicant.ApplicantId)
                .map(res => res.json())
                .subscribe(data => {
                    this.applicant = data;
                    resolve(this.applicant);
                });
        });
    }

    
    updateApplicant(applicant: any) {
         return new Promise(resolve => {
            this.http.put(this.apiUrl + '/Applicants', applicant)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    addNewApplicant(applicant: any) {
         return new Promise(resolve => {
            this.http.post(this.apiUrl + '/Applicants', applicant)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }

    deleteApplicant(applicant: any) {
         return new Promise(resolve => {
            this.http.delete(this.apiUrl + '/Applicants?applicantId=' + applicant.ApplicantId)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    
      
      
      
      
      
    public interviewers: any[];
    getInterviewers() {

        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Interviewers?expand=all')
                .map(res => res.json())
                .subscribe(data => {
                    this.interviewers = data;
                    resolve(this.interviewers);
                });
        });
    }

    public interviewer: any[];
    getInterviewer(interviewer: any) {
        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Interviewers?expand=all&interviewerId=' + interviewer.InterviewerId)
                .map(res => res.json())
                .subscribe(data => {
                    this.interviewer = data;
                    resolve(this.interviewer);
                });
        });
    }

    
    updateInterviewer(interviewer: any) {
         return new Promise(resolve => {
            this.http.put(this.apiUrl + '/Interviewers', interviewer)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    addNewInterviewer(interviewer: any) {
         return new Promise(resolve => {
            this.http.post(this.apiUrl + '/Interviewers', interviewer)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }

    deleteInterviewer(interviewer: any) {
         return new Promise(resolve => {
            this.http.delete(this.apiUrl + '/Interviewers?interviewerId=' + interviewer.InterviewerId)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    
      
      
      
      
      
    public positions: any[];
    getPositions() {

        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Positions?expand=all')
                .map(res => res.json())
                .subscribe(data => {
                    this.positions = data;
                    resolve(this.positions);
                });
        });
    }

    public position: any[];
    getPosition(position: any) {
        return new Promise(resolve => {
            this.http.get(this.apiUrl + '/Positions?expand=all&positionId=' + position.PositionId)
                .map(res => res.json())
                .subscribe(data => {
                    this.position = data;
                    resolve(this.position);
                });
        });
    }

    
    updatePosition(position: any) {
         return new Promise(resolve => {
            this.http.put(this.apiUrl + '/Positions', position)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    addNewPosition(position: any) {
         return new Promise(resolve => {
            this.http.post(this.apiUrl + '/Positions', position)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }

    deletePosition(position: any) {
         return new Promise(resolve => {
            this.http.delete(this.apiUrl + '/Positions?positionId=' + position.PositionId)
                .map(res => res.json())
                .subscribe(data => {
                    resolve(data);
                });
        });
    }
    


}

