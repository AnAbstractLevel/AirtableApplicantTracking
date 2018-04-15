import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../../../app/app.modules-base';
import { IonicBase } from '../../../../app/ionic-base';
import { RestAPIService } from '../../../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class ApplicantsBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        this.getApplicants();
        
    }
    
    public ApplicantsState = siteMap['Applicants'];

    public pages : any;

    

    public ApplicantState = siteMap['Applicant'];
    public parent : any;
    public applicants: any = []; 

    

    pop2() { 
        this.navCtrl.pop()
            .then(data => {
                this.navCtrl.pop();
            });
    }

    getApplicants() {
        return new Promise(resolve => {
            
            this.parent.reload()
                .then(result => {
                    this.applicants = result.Applicants;
                    resolve(result);
                })
            
        });
    }

    reload() { return this.getApplicants(); }

    addNewApplicant() { // 
        var newApplicant = {
        
            OnsiteInterviewer
             : this.parent.interviewer.InterviewerId,
            "Name" : "New Applicant " + (this.applicants ? this.applicants.length + 1 : 1),
            "Description" : ""
        }
        
        this.apiSvc.addNewApplicant(newApplicant)
            .then(data => {
                
                this.parent.reload();
                this.getApplicants();
                this.goToState(this.ApplicantState, data, true);
            });
            
    }
    

    

    
    goToRootState(state, applicant = {}, editMode = false) : Promise<any> {
        return this.goToState(state, applicant, editMode, true);
    }

    goToState(state, applicant = {}, editMode = false, setRoot = false)  : Promise<any> {
        if (setRoot) {
            return this.navCtrl.setRoot(state.component, { applicant : applicant, parent: this, editMode: editMode });
        } else {
            return this.navCtrl.push(state.component, { applicant : applicant, parent: this, editMode: editMode });
        }
    }

    goToUrl(url) {
        console.log('SIMULATING OPEN OF URL: ' + url);
    }

    
}

