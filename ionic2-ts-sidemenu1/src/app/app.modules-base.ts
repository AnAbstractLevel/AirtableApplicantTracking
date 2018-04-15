//
// ===== File globals.ts    
//

    
        import { Home } from '../pages/home/home';
    

    
        import { Interviewers } from '../pages/interviewers/interviewers';
    

    
        import { Interviewer } from '../pages/interviewers/interviewer/interviewer';
    

    
        import { Applicants } from '../pages/interviewers/interviewer/applicants/applicants';
    

    
        import { Applicant } from '../pages/interviewers/interviewer/applicants/applicant/applicant';
    

    
        import { Positions } from '../pages/positions/positions';
    

    
        import { Position } from '../pages/positions/position/position';
    

    
        import { PositionApplicants } from '../pages/positions/position/positionapplicants/positionapplicants';
    

    
        import { PositionApplicant } from '../pages/positions/position/positionapplicants/positionapplicant/positionapplicant';
    

    
        import { About } from '../pages/about/about';
    

    
        import { Contact } from '../pages/contact/contact';
    

    
        import { Chat } from '../pages/contact/chat/chat';
    

    
        import { Email } from '../pages/contact/email/email';
    

    
        import { Call } from '../pages/contact/call/call';
    


export const components : any[] = [Home, Interviewers, Interviewer, Applicants, Applicant, Positions, Position, PositionApplicants, PositionApplicant, About, Contact, Chat, Email, Call];

export const siteMap: { [name: string]: { name: string, title: string, component: any, parentComponent: any, subComponents: any[]; } } = {};

                            siteMap['Home'] = { name: 'Home', title: 'Home', component: Home, parentComponent: null, subComponents: [] };
                        
                            siteMap['Interviewers'] = { name: 'Interviewers', title: 'Interviewers', component: Interviewers, parentComponent: null, subComponents: [] };
                        
                            siteMap['Interviewer'] = { name: 'Interviewer', title: 'Interviewer', component: Interviewer, parentComponent: null, subComponents: [] };
                        
                            siteMap['Applicants'] = { name: 'Applicants', title: 'Applicants', component: Applicants, parentComponent: null, subComponents: [] };
                        
                            siteMap['Applicant'] = { name: 'Applicant', title: 'Applicant', component: Applicant, parentComponent: null, subComponents: [] };
                        
                            siteMap['Positions'] = { name: 'Positions', title: 'Positions', component: Positions, parentComponent: null, subComponents: [] };
                        
                            siteMap['Position'] = { name: 'Position', title: 'Position', component: Position, parentComponent: null, subComponents: [] };
                        
                            siteMap['PositionApplicants'] = { name: 'PositionApplicants', title: 'Applicants', component: PositionApplicants, parentComponent: null, subComponents: [] };
                        
                            siteMap['PositionApplicant'] = { name: 'PositionApplicant', title: 'Applicant', component: PositionApplicant, parentComponent: null, subComponents: [] };
                        
                            siteMap['About'] = { name: 'About', title: 'About', component: About, parentComponent: null, subComponents: [] };
                        
                            siteMap['Contact'] = { name: 'Contact', title: 'Contact', component: Contact, parentComponent: null, subComponents: [] };
                        
                            siteMap['Chat'] = { name: 'Chat', title: 'Chat', component: Chat, parentComponent: null, subComponents: [] };
                        
                            siteMap['Email'] = { name: 'Email', title: 'Email', component: Email, parentComponent: null, subComponents: [] };
                        
                            siteMap['Call'] = { name: 'Call', title: 'Call', component: Call, parentComponent: null, subComponents: [] };
                        


                                siteMap['Interviewers'].subComponents.push(siteMap['Interviewer']);
                            
                                siteMap['Interviewer'].parentComponent = siteMap['Interviewers'];
                            
                                siteMap['Interviewer'].subComponents.push(siteMap['Applicants']);
                            
                                siteMap['Applicants'].parentComponent = siteMap['Interviewer'];
                            
                                siteMap['Applicants'].subComponents.push(siteMap['Applicant']);
                            
                                siteMap['Applicant'].parentComponent = siteMap['Applicants'];
                            
                                siteMap['Positions'].subComponents.push(siteMap['Position']);
                            
                                siteMap['Position'].parentComponent = siteMap['Positions'];
                            
                                siteMap['Position'].subComponents.push(siteMap['PositionApplicants']);
                            
                                siteMap['PositionApplicants'].parentComponent = siteMap['Position'];
                            
                                siteMap['PositionApplicants'].subComponents.push(siteMap['PositionApplicant']);
                            
                                siteMap['PositionApplicant'].parentComponent = siteMap['PositionApplicants'];
                            
                                siteMap['Contact'].subComponents.push(siteMap['Chat']);
                            
                                siteMap['Contact'].subComponents.push(siteMap['Email']);
                            
                                siteMap['Contact'].subComponents.push(siteMap['Call']);
                            
                                siteMap['Chat'].parentComponent = siteMap['Contact'];
                            
                                siteMap['Email'].parentComponent = siteMap['Contact'];
                            
                                siteMap['Call'].parentComponent = siteMap['Contact'];
                            

export const pages : any[] = [

        siteMap['Home']
    , 
        siteMap['Interviewers']
    , 
        siteMap['Positions']
    , 
        siteMap['About']
    , 
        siteMap['Contact']
    
];

