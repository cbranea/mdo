#region CopyrightHeader
//
//  Copyright by Contributors
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//         http://www.apache.org/licenses/LICENSE-2.0.txt
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.
//
#endregion

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using gov.va.medora.mdo.dao;
using gov.va.medora.mdo.dao.sql.cdw;

namespace gov.va.medora.mdo.api
{
    public class EncounterApi
    {
        string DAO_NAME = "IEncounterDao";

        public EncounterApi() { }

        public IndexedHashtable getAppointments(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getAppointments", new object[] { });
        }

        public Dictionary<string, HashSet<string>> getUpdatedFutureAppointments(AbstractConnection cxn, DateTime updatedSince)
        {
            CdwEncounterDao dao = new CdwEncounterDao(cxn);
            return dao.getUpdatedFutureAppointments(updatedSince);
        }

        public Appointment[] getAppointments(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getAppointments();
        }

        public IndexedHashtable getAppointments(ConnectionSet cxns, int pastDays, int futureDays)
        {
            return cxns.query(DAO_NAME, "getAppointments", new object[] { pastDays, futureDays });
        }

        public Appointment[] getAppointments(AbstractConnection cxn, int pastDays, int futureDays)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getAppointments(pastDays,futureDays);
        }

        public IndexedHashtable getFutureAppointments(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getFutureAppointments", new object[] { });
        }

        public Appointment[] getFutureAppointments(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getFutureAppointments();
        }

        public string getAppointmentText(AbstractConnection cxn, string apptId)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getAppointmentText(apptId);
        }

        public IndexedHashtable getInpatientMoves(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getInpatientMoves", new object[] { });
        }

        public Adt[] getInpatientMoves(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getInpatientMoves();
        }

        public IndexedHashtable getInpatientMoves(ConnectionSet cxns, string fromDate, string toDate)
        {
            return cxns.query(DAO_NAME, "getInpatientMoves", new object[] { fromDate,toDate });
        }

        public IndexedHashtable getInpatientMoves(ConnectionSet cxns, string fromDate, string toDate, string iterLength)
        {
            return cxns.query(DAO_NAME, "getInpatientMoves", new object[] { fromDate, toDate, iterLength });
        }

        public Adt[] getInpatientMoves(AbstractConnection cxn, string fromDate, string toDate)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getInpatientMoves(fromDate, toDate);
        }

        public Adt[] getInpatientMovesByCheckinId(AbstractConnection cxn, string checkinId)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getInpatientMovesByCheckinId(checkinId);
        }

        public IndexedHashtable getInpatientMovesByCheckinId(ConnectionSet cxns, string checkinId)
        {
            return cxns.query(DAO_NAME, "getInpatientMovesByCheckinId", new object[] { checkinId });
        }

        public IndexedHashtable getLocations(ConnectionSet cxns, string target, string direction)
        {
            return cxns.query(DAO_NAME, "lookupLocations", new object[] { target, direction });
        }

        public HospitalLocation[] getLocations(AbstractConnection cxn, string target, string direction)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.lookupLocations(target, direction);
        }

        public IndexedHashtable getWards(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getWards", new object[] { });
        }

        public HospitalLocation[] getWards(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getWards();
        }

        public DictionaryHashList getSpecialties(AbstractConnection cxn)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getSpecialties();
        }

        public DictionaryHashList getTeams(AbstractConnection cxn)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getTeams();
        }

        public HospitalLocation[] getClinics(AbstractConnection cxn, string target, string direction)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getClinics(target, direction);
        }

        public InpatientStay[] getStaysForWard(AbstractConnection cxn, string wardId)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getStaysForWard(wardId);
        }

        public IndexedHashtable getDRGRecords(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getDRGRecords", new object[] { });
        }

        public Drg[] getDRGRecords(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getDRGRecords();
        }

        public IndexedHashtable getOutpatientEncounterReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getOutpatientEncounterReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getAdmissionsReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getAdmissionsReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getExpandedAdtReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getExpandedAdtReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getDischargesReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getDischargesReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getTransfersReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getTransfersReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getFutureClinicVisitsReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME,"getFutureClinicVisitsReport", new object[]{fromDate,toDate,nrpts});
        }

        public IndexedHashtable getPastClinicVisitsReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getPastClinicVisitsReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getTreatingSpecialtyReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getTreatingSpecialtyReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getCareTeamReports(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getCareTeamReport", new object[] { });
        }

        public IndexedHashtable getDischargeDiagnosisReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getDischargeDiagnosisReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getCompAndPenReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getCompAndPenReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getIcdProceduresReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getIcdProceduresReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getIcdSurgeryReports(ConnectionSet cxns, string fromDate, string toDate, int nrpts)
        {
            return cxns.query(DAO_NAME, "getIcdSurgeryReport", new object[] { fromDate, toDate, nrpts });
        }

        public IndexedHashtable getAdmissions(ConnectionSet cxns)
        {
            return cxns.query(DAO_NAME, "getAdmissions", new object[] { });
        }

        public InpatientStay[] getAdmissions(AbstractConnection cxn)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getAdmissions();
        }

        public IndexedHashtable getVisits(ConnectionSet cxns, string fromDate, string toDate)
        {
            return cxns.query(DAO_NAME,"getVisits",new object[]{fromDate, toDate});
        }

        public Visit[] getVisits(AbstractConnection cxn, string fromDate, string toDate)
        {
            IEncounterDao dao = (IEncounterDao)cxn.getDao(DAO_NAME);
            if (dao == null)
            {
                return null;
            }
            return dao.getVisits(fromDate, toDate);
        }

        public Adt[] getInpatientDischarges(AbstractConnection cxn, string pid)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getInpatientDischarges(pid);
        }

        public IndexedHashtable getStayMovementsByDateRange(ConnectionSet cxns, string fromDate, string toDate)
        {
            return cxns.query(DAO_NAME, "getStayMovementsByDateRange", new object[] { fromDate, toDate });
        }

        public InpatientStay[] getStayMovementsByDateRange(AbstractConnection cxn, string fromDate, string toDate)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getStayMovementsByDateRange(fromDate, toDate);
        }

        public IndexedHashtable getStayMovementsByPatient(ConnectionSet cxns, string dfn)
        {
            return cxns.query(DAO_NAME, "getStayMovementsByPatient", new object[] { dfn });
        }

        public InpatientStay getStayMovements(AbstractConnection cxn, string checkinId)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getStayMovements(checkinId);
        }

        public Site[] getSiteDivisions(AbstractConnection cxn, string siteId)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getSiteDivisions(siteId);
        }

        public IList<Appointment> getPendingAppointments(AbstractConnection cxn, string startDate)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getPendingAppointments(startDate);
        }

        public IList<AppointmentType> getAppointmentTypes(AbstractConnection cxn, string target)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getAppointmentTypes(target);
        }

        public string getClinicAvailability(AbstractConnection cxn, string clinicId)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getClinicAvailability(clinicId);
        }

        public Appointment makeAppointment(AbstractConnection cxn, Appointment appointment)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).makeAppointment(appointment);
        }

        public Appointment cancelAppointment(AbstractConnection cxn, Appointment appointment)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).cancelAppointment(appointment);
        }

        public Appointment checkInAppointment(AbstractConnection cxn, Appointment appointment)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).checkInAppointment(appointment);
        }

        public HospitalLocation getClinicSchedulingDetails(AbstractConnection cxn, string clinicId)
        {
            return ((IEncounterDao)cxn.getDao(DAO_NAME)).getClinicSchedulingDetails(clinicId);
        }
    }
}
