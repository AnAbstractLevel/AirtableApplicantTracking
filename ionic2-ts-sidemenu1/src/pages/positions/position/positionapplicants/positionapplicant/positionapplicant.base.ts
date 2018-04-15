import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../../../../app/app.modules-base';
import { IonicBase } from '../../../../../app/ionic-base';
import { RestAPIService } from '../../../../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class PositionApplicantBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        
        this.applicant = this.navParams.get('applicant') || this.applicant;
        this.getPositionApplicant();
        this.editMode = this.navParams.get("editMode");
    }
    
    public PositionApplicantState = siteMap['PositionApplicant'];

    public pages : any;

    public parent : any;

    
    public positionapplicant: any = {};
    
    public applicant: any = {};
    public canDelete: any = true;
    public editMode = false;

    pop() {
        this.navCtrl.pop();
    }

    getPositionApplicant() {
        return new Promise(resolve => {
            let positionapplicant = this.navParams.get("positionapplicant");
            if (!positionapplicant) positionapplicant = this.navParams.get("applicant");

            
            this.apiSvc.getApplicant(positionapplicant)
                .then(data => {
                    this.positionapplicant = data;
                    this.canDelete = true;

                    // Check if they can actually delete
                    

                    resolve(data);
                });
            
        });
    }
    
    reload() { return this.getPositionApplicant(); }

    updateApplicant(theApplicantToUpdate) {
            

        this.apiSvc.updateApplicant(theApplicantToUpdate)
            .then(data => {
                 
                this.parent
                    .reload()
                    .then(parentResult => {
                        this.getPositionApplicant();
                        this.editMode = false;
                    });
            });
            
    }


    deleteApplicant() {
        

        this.apiSvc.deleteApplicant(this.positionapplicant)
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

