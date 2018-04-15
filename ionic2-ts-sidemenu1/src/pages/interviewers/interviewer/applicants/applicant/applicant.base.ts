import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../../../../app/app.modules-base';
import { IonicBase } from '../../../../../app/ionic-base';
import { RestAPIService } from '../../../../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class ApplicantBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        
        this.applicant = this.navParams.get('applicant') || this.applicant;
        this.getApplicant();
        this.editMode = this.navParams.get("editMode");
    }
    
    public ApplicantState = siteMap['Applicant'];

    public pages : any;

    public parent : any;

    
    public applicant: any = {};
    ;
    public canDelete: any = true;
    public editMode = false;

    pop() {
        this.navCtrl.pop();
    }

    getApplicant() {
        return new Promise(resolve => {
            let applicant = this.navParams.get("applicant");
            if (!applicant) applicant = this.navParams.get("applicant");

            
            this.apiSvc.getApplicant(applicant)
                .then(data => {
                    this.applicant = data;
                    this.canDelete = true;

                    // Check if they can actually delete
                    

                    resolve(data);
                });
            
        });
    }
    
    reload() { return this.getApplicant(); }

    updateApplicant(theApplicantToUpdate) {
            

        this.apiSvc.updateApplicant(theApplicantToUpdate)
            .then(data => {
                 
                this.parent
                    .reload()
                    .then(parentResult => {
                        this.getApplicant();
                        this.editMode = false;
                    });
            });
            
    }


    deleteApplicant() {
        

        this.apiSvc.deleteApplicant(this.applicant)
            .then(data => {
                this.parent
                    .reload()
                    .then(parentResult => {
                         this.navCtrl.pop();
                    });
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

