import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../app/app.modules-base';
import { IonicBase } from '../../app/ionic-base';
import { RestAPIService } from '../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class InterviewersBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        this.getInterviewers();
        
    }
    
    public InterviewersState = siteMap['Interviewers'];

    public pages : any;

    

    public InterviewerState = siteMap['Interviewer'];
    public parent : any;
    public interviewers: any = []; 

    

    pop2() { 
        this.navCtrl.pop()
            .then(data => {
                this.navCtrl.pop();
            });
    }

    getInterviewers() {
        return new Promise(resolve => {
            
            this.apiSvc.getInterviewers()
                .then(result => { 
                    this.interviewers = result;
                    resolve(result);
                });
        });
    }

    reload() { return this.getInterviewers(); }

    addNewInterviewer() { // 
        var newInterviewer = {
            "Name" : "New Interviewer " + (this.interviewers ? this.interviewers.length + 1 : 1),
            "Description" : ""
        }
        
        this.apiSvc.addNewInterviewer(newInterviewer)
            .then(data => {
                
                this.getInterviewers();
                this.goToState(this.InterviewerState, data, true);
            });
            
    }
    

    

    
    goToRootState(state, interviewer = {}, editMode = false) : Promise<any> {
        return this.goToState(state, interviewer, editMode, true);
    }

    goToState(state, interviewer = {}, editMode = false, setRoot = false)  : Promise<any> {
        if (setRoot) {
            return this.navCtrl.setRoot(state.component, { interviewer : interviewer, parent: this, editMode: editMode });
        } else {
            return this.navCtrl.push(state.component, { interviewer : interviewer, parent: this, editMode: editMode });
        }
    }

    goToUrl(url) {
        console.log('SIMULATING OPEN OF URL: ' + url);
    }

    
}

