import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../../app/app.modules-base';
import { IonicBase } from '../../../app/ionic-base';
import { RestAPIService } from '../../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class InterviewerBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        
        this.interviewer = this.navParams.get('interviewer') || this.interviewer;
        this.getInterviewer();
        this.editMode = this.navParams.get("editMode");
    }
    
    public InterviewerState = siteMap['Interviewer'];

    public pages : any;

    

    public ApplicantsState = siteMap['Applicants'];
    public parent : any;

    
    public interviewer: any = {};
    ;
    public canDelete: any = true;
    public editMode = false;

    pop() {
        this.navCtrl.pop();
    }

    getInterviewer() {
        return new Promise(resolve => {
            let interviewer = this.navParams.get("interviewer");
            if (!interviewer) interviewer = this.navParams.get("interviewer");

            
            this.apiSvc.getInterviewer(interviewer)
                .then(data => {
                    this.interviewer = data;
                    this.canDelete = true;

                    // Check if they can actually delete
                    
                    
                    if (this.interviewer.Applicants && this.interviewer.Applicants.length > 0) {
                        this.canDelete = false;
                    }
                    

                    resolve(data);
                });
            
        });
    }
    
    reload() { return this.getInterviewer(); }

    updateInterviewer(theInterviewerToUpdate) {
            

        this.apiSvc.updateInterviewer(theInterviewerToUpdate)
            .then(data => {
                 
                this.parent
                    .reload()
                    .then(parentResult => {
                        this.getInterviewer();
                        this.editMode = false;
                    });
            });
            
    }


    deleteInterviewer() {
        

        this.apiSvc.deleteInterviewer(this.interviewer)
            .then(data => {
                this.parent
                    .reload()
                    .then(parentResult => {
                         this.navCtrl.pop();
                    });
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

