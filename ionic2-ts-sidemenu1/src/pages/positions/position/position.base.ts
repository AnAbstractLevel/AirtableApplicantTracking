import { Component } from '@angular/core';

import { NavController } from 'ionic-angular';
import { NavParams } from 'ionic-angular';
import { siteMap } from '../../../app/app.modules-base';
import { IonicBase } from '../../../app/ionic-base';
import { RestAPIService } from '../../../providers/rest-api-service';
import { Observable } from 'rxjs/Observable';
import { Subject } from "rxjs/Subject";
import { Storage } from '@ionic/storage';

export class PositionBase extends IonicBase {

    constructor(public navCtrl: NavController, public navParams: NavParams, public apiSvc: RestAPIService) {
        super()
        this.parent = this.navParams.get("parent");
        this.pages = siteMap;
        
        this.position = this.navParams.get('position') || this.position;
        this.getPosition();
        this.editMode = this.navParams.get("editMode");
    }
    
    public PositionState = siteMap['Position'];

    public pages : any;

    

    public PositionApplicantsState = siteMap['PositionApplicants'];
    public parent : any;

    
    public position: any = {};
    ;
    public canDelete: any = true;
    public editMode = false;

    pop() {
        this.navCtrl.pop();
    }

    getPosition() {
        return new Promise(resolve => {
            let position = this.navParams.get("position");
            if (!position) position = this.navParams.get("position");

            
            this.apiSvc.getPosition(position)
                .then(data => {
                    this.position = data;
                    this.canDelete = true;

                    // Check if they can actually delete
                    
                    
                    if (this.position.Applicants && this.position.Applicants.length > 0) {
                        this.canDelete = false;
                    }
                    

                    resolve(data);
                });
            
        });
    }
    
    reload() { return this.getPosition(); }

    updatePosition(thePositionToUpdate) {
            

        this.apiSvc.updatePosition(thePositionToUpdate)
            .then(data => {
                 
                this.parent
                    .reload()
                    .then(parentResult => {
                        this.getPosition();
                        this.editMode = false;
                    });
            });
            
    }


    deletePosition() {
        

        this.apiSvc.deletePosition(this.position)
            .then(data => {
                this.parent
                    .reload()
                    .then(parentResult => {
                         this.navCtrl.pop();
                    });
            });
            
    }

    
    goToRootState(state, position = {}, editMode = false) : Promise<any> {
        return this.goToState(state, position, editMode, true);
    }

    goToState(state, position = {}, editMode = false, setRoot = false)  : Promise<any> {
        if (setRoot) {
            return this.navCtrl.setRoot(state.component, { position : position, parent: this, editMode: editMode });
        } else {
            return this.navCtrl.push(state.component, { position : position, parent: this, editMode: editMode });
        }
    }

    goToUrl(url) {
        console.log('SIMULATING OPEN OF URL: ' + url);
    }

    
}

