/*  This file is part of Chummer5a.
 *
 *  Chummer5a is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  Chummer5a is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with Chummer5a.  If not, see <http://www.gnu.org/licenses/>.
 *
 *  You can obtain the full source code for Chummer5a at
 *  https://github.com/chummer5a/chummer5a
 */
using System;
using System.Windows.Navigation;
using System.Xml;
using Chummer.Classes;

namespace Chummer
{
    public static class ImprovementMethods
    {
        /// <summary>
        /// Gets an AddImprovementCollection function based on its name.
        /// </summary>
        /// <param name="strMethodName">Name of the function, in all uppercase.</param>
        /// <param name="objImprovementAdder">Container for the function (since they're not static, we need a container).</param>
        /// <returns>Function pointer to the named function if one is found. If none are found, returns a null pointer.</returns>
        public static Action<XmlNode> GetMethod(string strMethodName, [Annotations.NotNull] AddImprovementCollection objImprovementAdder)
        {
            // Switch-cases get compiled as hashes, so this is as close as you can get to a compile-time Dictionary
            switch (strMethodName)
            {
                case "QUALITYLEVEL":
                    return objImprovementAdder.qualitylevel;
                case "SELECTTEXT":
                    return objImprovementAdder.selecttext;
                case "SPELLRESISTANCE":
                    return objImprovementAdder.spellresistance;
                case "MENTALMANIPULATIONRESIST":
                    return objImprovementAdder.mentalmanipulationresist;
                case "PHYSICALMANIPULATIONRESIST":
                    return objImprovementAdder.physicalmanipulationresist;
                case "MANAILLUSIONRESIST":
                    return objImprovementAdder.manaillusionresist;
                case "PHYSICALILLUSIONRESIST":
                    return objImprovementAdder.physicalillusionresist;
                case "DETECTIONSPELLRESIST":
                    return objImprovementAdder.detectionspellresist;
                case "ENABLEATTRIBUTE":
                    return objImprovementAdder.enableattribute;
                case "REPLACEATTRIBUTES":
                    return objImprovementAdder.replaceattributes;
                case "ENABLETAB":
                    return objImprovementAdder.enabletab;
                case "DISABLETAB":
                    return objImprovementAdder.disabletab;
                case "SELECTRESTRICTED":
                    return objImprovementAdder.selectrestricted;
                case "SELECTTRADITION":
                    return objImprovementAdder.selecttradition;
                case "CYBERSEEKER":
                    return objImprovementAdder.cyberseeker;
                case "BLOCKSKILLGROUPDEFAULTING":
                    return objImprovementAdder.blockskillgroupdefaulting;
                case "SELECTSKILL":
                    return objImprovementAdder.selectskill;
                case "SELECTSKILLGROUP":
                    return objImprovementAdder.selectskillgroup;
                case "SELECTATTRIBUTES":
                    return objImprovementAdder.selectattributes;
                case "SELECTATTRIBUTE":
                    return objImprovementAdder.selectattribute;
                case "SELECTLIMIT":
                    return objImprovementAdder.selectlimit;
                case "SWAPSKILLATTRIBUTE":
                    return objImprovementAdder.swapskillattribute;
                case "SWAPSKILLSPECATTRIBUTE":
                    return objImprovementAdder.swapskillspecattribute;
                case "SELECTSPELL":
                    return objImprovementAdder.selectspell;
                case "ADDSPELL":
                    return objImprovementAdder.addspell;
                case "SELECTCOMPLEXFORM":
                    return objImprovementAdder.selectcomplexform;
                case "ADDCOMPLEXFORM":
                    return objImprovementAdder.addcomplexform;
                case "ADDGEAR":
                    return objImprovementAdder.addgear;
                case "ADDWEAPON":
                    return objImprovementAdder.addweapon;
                case "SELECTAIPROGRAM":
                    return objImprovementAdder.selectaiprogram;
                case "SELECTINHERENTAIPROGRAM":
                    return objImprovementAdder.selectinherentaiprogram;
                case "SELECTCONTACT":
                    return objImprovementAdder.selectcontact;
                case "ADDCONTACT":
                    return objImprovementAdder.addcontact;
                case "SPECIFICATTRIBUTE":
                    return objImprovementAdder.specificattribute;
                case "ATTRIBUTELEVEL":
                    return objImprovementAdder.attributelevel;
                case "SKILLLEVEL":
                    return objImprovementAdder.skilllevel;
                case "PUSHTEXT":
                    return objImprovementAdder.pushtext;
                case "ACTIVESOFT":
                    return objImprovementAdder.activesoft;
                case "SKILLSOFT":
                    return objImprovementAdder.skillsoft;
                case "KNOWLEDGESKILLLEVEL":
                    return objImprovementAdder.knowledgeskilllevel;
                case "KNOWLEDGESKILLPOINTS":
                    return objImprovementAdder.knowledgeskillpoints;
                case "SKILLGROUPLEVEL":
                    return objImprovementAdder.skillgrouplevel;
                case "NUYENMAXBP":
                    return objImprovementAdder.nuyenmaxbp;
                case "PHYSICALLIMIT":
                    return objImprovementAdder.physicallimit;
                case "MENTALLIMIT":
                    return objImprovementAdder.mentallimit;
                case "SOCIALLIMIT":
                    return objImprovementAdder.sociallimit;
                case "NUYENAMT":
                    return objImprovementAdder.nuyenamt;
                case "CONDITIONMONITOR":
                    return objImprovementAdder.conditionmonitor;
                case "LIVINGPERSONA":
                    return objImprovementAdder.livingpersona;
                case "SPECIFICSKILL":
                    return objImprovementAdder.specificskill;
                case "REFLEXRECORDEROPTIMIZATION":
                    return objImprovementAdder.reflexrecorderoptimization;
                case "MARTIALART":
                    return objImprovementAdder.martialart;
                case "LIMITMODIFIER":
                    return objImprovementAdder.limitmodifier;
                case "SKILLCATEGORY":
                    return objImprovementAdder.skillcategory;
                case "SKILLGROUP":
                    return objImprovementAdder.skillgroup;
                case "SKILLATTRIBUTE":
                    return objImprovementAdder.skillattribute;
                case "SKILLLINKEDATTRIBUTE":
                    return objImprovementAdder.skilllinkedattribute;
                case "SKILLARTICULATION":
                    return objImprovementAdder.skillarticulation;
                case "ARMOR":
                    return objImprovementAdder.armor;
                case "FIREARMOR":
                    return objImprovementAdder.firearmor;
                case "COLDARMOR":
                    return objImprovementAdder.coldarmor;
                case "ELECTRICITYARMOR":
                    return objImprovementAdder.electricityarmor;
                case "ACIDARMOR":
                    return objImprovementAdder.acidarmor;
                case "FALLINGARMOR":
                    return objImprovementAdder.fallingarmor;
                case "DODGE":
                    return objImprovementAdder.dodge;
                case "REACH":
                    return objImprovementAdder.reach;
                case "UNARMEDDV":
                    return objImprovementAdder.unarmeddv;
                case "UNARMEDDVPHYSICAL":
                    return objImprovementAdder.unarmeddvphysical;
                case "UNARMEDAP":
                    return objImprovementAdder.unarmedap;
                case "UNARMEDREACH":
                    return objImprovementAdder.unarmedreach;
                case "INITIATIVE":
                    return objImprovementAdder.initiative;
                case "INITIATIVEPASS":
                    return objImprovementAdder.initiativepass;
                case "INITIATIVEDICE":
                    return objImprovementAdder.initiativedice;
                case "INITIATIVEPASSADD":
                    return objImprovementAdder.initiativepassadd;
                case "INITIATIVEDICEADD":
                    return objImprovementAdder.initiativediceadd;
                case "MATRIXINITIATIVE":
                    return objImprovementAdder.matrixinitiative;
                case "MATRIXINITIATIVEPASS":
                    return objImprovementAdder.matrixinitiativepass;
                case "MATRIXINITIATIVEDICE":
                    return objImprovementAdder.matrixinitiativedice;
                case "MATRIXINITIATIVEPASSADD":
                    return objImprovementAdder.matrixinitiativepassadd;
                case "MATRIXINITIATIVEDICEADD":
                    return objImprovementAdder.matrixinitiativediceadd;
                case "LIFESTYLECOST":
                    return objImprovementAdder.lifestylecost;
                case "BASICLIFESTYLECOST":
                    return objImprovementAdder.basiclifestylecost;
                case "GENETECHCOSTMULTIPLIER":
                    return objImprovementAdder.genetechcostmultiplier;
                case "BASICBIOWAREESSMULTIPLIER":
                    return objImprovementAdder.basicbiowareessmultiplier;
                case "BIOWAREESSMULTIPLIER":
                    return objImprovementAdder.biowareessmultiplier;
                case "BIOWARETOTALESSMULTIPLIER":
                    return objImprovementAdder.biowaretotalessmultiplier;
                case "CYBERWAREESSMULTIPLIER":
                    return objImprovementAdder.cyberwareessmultiplier;
                case "CYBERWARETOTALESSMULTIPLIER":
                    return objImprovementAdder.cyberwaretotalessmultiplier;
                case "BIOWAREESSMULTIPLIERNONRETROACTIVE":
                    return objImprovementAdder.biowareessmultipliernonretroactive;
                case "BIOWARETOTALESSMULTIPLIERNONRETROACTIVE":
                    return objImprovementAdder.biowaretotalessmultipliernonretroactive;
                case "CYBERWAREESSMULTIPLIERNONRETROACTIVE":
                    return objImprovementAdder.cyberwareessmultipliernonretroactive;
                case "CYBERWARETOTALESSMULTIPLIERNONRETROACTIVE":
                    return objImprovementAdder.cyberwaretotalessmultipliernonretroactive;
                case "PROTOTYPETRANSHUMAN":
                    return objImprovementAdder.prototypetranshuman;
                case "FRIENDSINHIGHPLACES":
                    return objImprovementAdder.friendsinhighplaces;
                case "EXCON":
                    return objImprovementAdder.excon;
                case "TRUSTFUND":
                    return objImprovementAdder.trustfund;
                case "MADEMAN":
                    return objImprovementAdder.mademan;
                case "FAME":
                    return objImprovementAdder.fame;
                case "ERASED":
                    return objImprovementAdder.erased;
                case "OVERCLOCKER":
                    return objImprovementAdder.overclocker;
                case "RESTRICTEDGEAR":
                    return objImprovementAdder.restrictedgear;
                case "NATIVELANGUAGELIMIT":
                    return objImprovementAdder.nativelanguagelimit;
                case "AMBIDEXTROUS":
                    return objImprovementAdder.ambidextrous;
                case "WEAPONCATEGORYDV":
                    return objImprovementAdder.weaponcategorydv;
                case "WEAPONCATEGORYDICE":
                    return objImprovementAdder.weaponcategorydice;
                case "SELECTMENTORSPIRIT":
                    return objImprovementAdder.selectmentorspirit;
                case "SELECTPARAGON":
                    return objImprovementAdder.selectparagon;
                case "SMARTLINK":
                    return objImprovementAdder.smartlink;
                case "ADAPSIN":
                    return objImprovementAdder.adapsin;
                case "SOFTWEAVE":
                    return objImprovementAdder.softweave;
                case "DISABLEBIOWARE":
                    return objImprovementAdder.disablebioware;
                case "DISABLECYBERWARE":
                    return objImprovementAdder.disablecyberware;
                case "DISABLEBIOWAREGRADE":
                    return objImprovementAdder.disablebiowaregrade;
                case "DISABLECYBERWAREGRADE":
                    return objImprovementAdder.disablecyberwaregrade;
                case "WALKMULTIPLIER":
                    return objImprovementAdder.walkmultiplier;
                case "RUNMULTIPLIER":
                    return objImprovementAdder.runmultiplier;
                case "SPRINTBONUS":
                    return objImprovementAdder.sprintbonus;
                case "FREEPOSITIVEQUALITIES":
                    return objImprovementAdder.freepositivequalities;
                case "FREENEGATIVEQUALITIES":
                    return objImprovementAdder.freenegativequalities;
                case "SELECTSIDE":
                    return objImprovementAdder.selectside;
                case "FREESPIRITPOWERPOINTS":
                    return objImprovementAdder.freespiritpowerpoints;
                case "ADEPTPOWERPOINTS":
                    return objImprovementAdder.adeptpowerpoints;
                case "SPECIFICPOWER":
                    return objImprovementAdder.specificpower;
                case "SELECTPOWERS":
                    return objImprovementAdder.selectpowers;
                case "ARMORENCUMBRANCEPENALTY":
                    return objImprovementAdder.armorencumbrancepenalty;
                case "INITIATION":
                    return objImprovementAdder.initiation;
                case "SUBMERSION":
                    return objImprovementAdder.submersion;
                case "ADDMETAMAGIC":
                    return objImprovementAdder.addmetamagic;
                case "SELECTMETAMAGIC":
                    return objImprovementAdder.selectmetamagic;
                case "ADDECHO":
                    return objImprovementAdder.addecho;
                case "SELECTECHO":
                    return objImprovementAdder.selectecho;
                case "SKILLWIRE":
                    return objImprovementAdder.skillwire;
                case "HARDWIRES":
                    return objImprovementAdder.hardwires;
                case "DAMAGERESISTANCE":
                    return objImprovementAdder.damageresistance;
                case "RESTRICTEDITEMCOUNT":
                    return objImprovementAdder.restricteditemcount;
                case "JUDGEINTENTIONS":
                    return objImprovementAdder.judgeintentions;
                case "JUDGEINTENTIONSOFFENSE":
                    return objImprovementAdder.judgeintentionsoffense;
                case "JUDGEINTENTIONSDEFENSE":
                    return objImprovementAdder.judgeintentionsdefense;
                case "COMPOSURE":
                    return objImprovementAdder.composure;
                case "LIFTANDCARRY":
                    return objImprovementAdder.liftandcarry;
                case "MEMORY":
                    return objImprovementAdder.memory;
                case "FATIGUERESIST":
                    return objImprovementAdder.fatigueresist;
                case "RADIATIONRESIST":
                    return objImprovementAdder.radiationresist;
                case "SONICRESIST":
                    return objImprovementAdder.sonicresist;
                case "TOXINCONTACTRESIST":
                    return objImprovementAdder.toxincontactresist;
                case "TOXININGESTIONRESIST":
                    return objImprovementAdder.toxiningestionresist;
                case "TOXININHALATIONRESIST":
                    return objImprovementAdder.toxininhalationresist;
                case "TOXININJECTIONRESIST":
                    return objImprovementAdder.toxininjectionresist;
                case "PATHOGENCONTACTRESIST":
                    return objImprovementAdder.pathogencontactresist;
                case "PATHOGENINGESTIONRESIST":
                    return objImprovementAdder.pathogeningestionresist;
                case "PATHOGENINHALATIONRESIST":
                    return objImprovementAdder.pathogeninhalationresist;
                case "PATHOGENINJECTIONRESIST":
                    return objImprovementAdder.pathogeninjectionresist;
                case "TOXINCONTACTIMMUNE":
                    return objImprovementAdder.toxincontactimmune;
                case "TOXININGESTIONIMMUNE":
                    return objImprovementAdder.toxiningestionimmune;
                case "TOXININHALATIONIMMUNE":
                    return objImprovementAdder.toxininhalationimmune;
                case "TOXININJECTIONIMMUNE":
                    return objImprovementAdder.toxininjectionimmune;
                case "PATHOGENCONTACTIMMUNE":
                    return objImprovementAdder.pathogencontactimmune;
                case "PATHOGENINGESTIONIMMUNE":
                    return objImprovementAdder.pathogeningestionimmune;
                case "PATHOGENINHALATIONIMMUNE":
                    return objImprovementAdder.pathogeninhalationimmune;
                case "PATHOGENINJECTIONIMMUNE":
                    return objImprovementAdder.pathogeninjectionimmune;
                case "PHYSIOLOGICALADDICTIONFIRSTTIME":
                    return objImprovementAdder.physiologicaladdictionfirsttime;
                case "PSYCHOLOGICALADDICTIONFIRSTTIME":
                    return objImprovementAdder.psychologicaladdictionfirsttime;
                case "PHYSIOLOGICALADDICTIONALREADYADDICTED":
                    return objImprovementAdder.physiologicaladdictionalreadyaddicted;
                case "PSYCHOLOGICALADDICTIONALREADYADDICTED":
                    return objImprovementAdder.psychologicaladdictionalreadyaddicted;
                case "STUNCMRECOVERY":
                    return objImprovementAdder.stuncmrecovery;
                case "PHYSICALCMRECOVERY":
                    return objImprovementAdder.physicalcmrecovery;
                case "ADDESSTOSTUNCMRECOVERY":
                    return objImprovementAdder.addesstostuncmrecovery;
                case "ADDESSTOPHYSICALCMRECOVERY":
                    return objImprovementAdder.addesstophysicalcmrecovery;
                case "CONCEALABILITY":
                    return objImprovementAdder.concealability;
                case "DRAINRESIST":
                    return objImprovementAdder.drainresist;
                case "DRAINVALUE":
                    return objImprovementAdder.drainvalue;
                case "FADINGRESIST":
                    return objImprovementAdder.fadingresist;
                case "FADINGVALUE":
                    return objImprovementAdder.fadingvalue;
                case "NOTORIETY":
                    return objImprovementAdder.notoriety;
                case "STREETCRED":
                    return objImprovementAdder.streetcred;
                case "STREETCREDMULTIPLIER":
                    return objImprovementAdder.streetcredmultiplier;
                case "COMPLEXFORMLIMIT":
                    return objImprovementAdder.complexformlimit;
                case "SPELLLIMIT":
                    return objImprovementAdder.spelllimit;
                case "FREESPELLS":
                    return objImprovementAdder.freespells;
                case "SPELLCATEGORY":
                    return objImprovementAdder.spellcategory;
                case "SPELLCATEGORYDRAIN":
                    return objImprovementAdder.spellcategorydrain;
                case "SPELLCATEGORYDAMAGE":
                    return objImprovementAdder.spellcategorydamage;
                case "THROWRANGE":
                    return objImprovementAdder.throwrange;
                case "THROWSTR":
                    return objImprovementAdder.throwstr;
                case "SKILLSOFTACCESS":
                    return objImprovementAdder.skillsoftaccess;
                case "QUICKENINGMETAMAGIC":
                    return objImprovementAdder.quickeningmetamagic;
                case "IGNORECMPENALTYSTUN":
                    return objImprovementAdder.ignorecmpenaltystun;
                case "IGNORECMPENALTYPHYSICAL":
                    return objImprovementAdder.ignorecmpenaltyphysical;
                case "CYBORGESSENCE":
                    return objImprovementAdder.cyborgessence;
                case "ESSENCEPENALTY":
                    return objImprovementAdder.essencepenalty;
                case "ESSENCEPENALTYT100":
                    return objImprovementAdder.essencepenaltyt100;
                case "ESSENCEPENALTYMAGONLYT100":
                    return objImprovementAdder.essencepenaltymagonlyt100;
                case "ESSENCEMAX":
                    return objImprovementAdder.essencemax;
                case "SELECTSPRITE":
                    return objImprovementAdder.selectsprite;
                case "BLACKMARKETDISCOUNT":
                    return objImprovementAdder.blackmarketdiscount;
                case "SELECTARMOR":
                    return objImprovementAdder.selectarmor;
                case "SELECTCYBERWARE":
                    return objImprovementAdder.selectcyberware;
                case "SELECTWEAPON":
                    return objImprovementAdder.selectweapon;
                case "OPTIONALPOWERS":
                    return objImprovementAdder.optionalpowers;
                case "CRITTERPOWERS":
                    return objImprovementAdder.critterpowers;
                case "CRITTERPOWERLEVELS":
                    return objImprovementAdder.critterpowerlevels;
                case "PUBLICAWARENESS":
                    return objImprovementAdder.publicawareness;
                case "DEALERCONNECTION":
                    return objImprovementAdder.dealerconnection;
                case "UNLOCKSKILLS":
                    return objImprovementAdder.unlockskills;
                case "ADDQUALITIES":
                    return objImprovementAdder.addqualities;
                case "SELECTQUALITY":
                    return objImprovementAdder.selectquality;
                case "ADDSKILLSPECIALIZATION":
                    return objImprovementAdder.addskillspecialization;
                case "ADDSKILLSPECIALIZATIONOPTION":
                    return objImprovementAdder.addskillspecializationoption;
                case "LIMITSPELLCATEGORY":
                    return objImprovementAdder.limitspellcategory;
                case "LIMITSPELLDESCRIPTOR":
                    return objImprovementAdder.limitspelldescriptor;
                case "LIMITSPIRITCATEGORY":
                    return objImprovementAdder.limitspiritcategory;
                case "MOVEMENTREPLACE":
                    return objImprovementAdder.movementreplace;
                case "ADDLIMB":
                    return objImprovementAdder.addlimb;
                case "ATTRIBUTEKARMACOST":
                    return objImprovementAdder.attributekarmacost;
                case "ACTIVESKILLKARMACOST":
                    return objImprovementAdder.activeskillkarmacost;
                case "SKILLGROUPKARMACOST":
                    return objImprovementAdder.skillgroupkarmacost;
                case "KNOWLEDGESKILLKARMACOST":
                    return objImprovementAdder.knowledgeskillkarmacost;
                case "SKILLGROUPDISABLE":
                    return objImprovementAdder.skillgroupdisable;
                case "SKILLGROUPCATEGORYDISABLE":
                    return objImprovementAdder.skillgroupcategorydisable;
                case "SKILLGROUPCATEGORYKARMACOST":
                    return objImprovementAdder.skillgroupcategorykarmacost;
                case "SKILLCATEGORYKARMACOST":
                    return objImprovementAdder.skillcategorykarmacost;
                case "SKILLCATEGORYSPECIALIZATIONKARMACOST":
                    return objImprovementAdder.skillcategoryspecializationkarmacost;
                case "ATTRIBUTEPOINTCOST":
                    return objImprovementAdder.attributepointcost;
                case "ACTIVESKILLPOINTCOST":
                    return objImprovementAdder.activeskillpointcost;
                case "SKILLGROUPPOINTCOST":
                    return objImprovementAdder.skillgrouppointcost;
                case "KNOWLEDGESKILLPOINTCOST":
                    return objImprovementAdder.knowledgeskillpointcost;
                case "SKILLGROUPCATEGORYPOINTCOST":
                    return objImprovementAdder.skillgroupcategorypointcost;
                case "SKILLCATEGORYPOINTCOST":
                    return objImprovementAdder.skillcategorypointcost;
                case "NEWSPELLKARMACOST":
                    return objImprovementAdder.newspellkarmacost;
                case "NEWCOMPLEXFORMKARMACOST":
                    return objImprovementAdder.newcomplexformkarmacost;
                case "NEWAIPROGRAMKARMACOST":
                    return objImprovementAdder.newaiprogramkarmacost;
                case "NEWAIADVANCEDPROGRAMKARMACOST":
                    return objImprovementAdder.newaiadvancedprogramkarmacost;
                case "ATTRIBUTEKARMACOSTMULTIPLIER":
                    return objImprovementAdder.attributekarmacostmultiplier;
                case "ACTIVESKILLKARMACOSTMULTIPLIER":
                    return objImprovementAdder.activeskillkarmacostmultiplier;
                case "SKILLGROUPKARMACOSTMULTIPLIER":
                    return objImprovementAdder.skillgroupkarmacostmultiplier;
                case "KNOWLEDGESKILLKARMACOSTMULTIPLIER":
                    return objImprovementAdder.knowledgeskillkarmacostmultiplier;
                case "SKILLGROUPCATEGORYKARMACOSTMULTIPLIER":
                    return objImprovementAdder.skillgroupcategorykarmacostmultiplier;
                case "SKILLCATEGORYKARMACOSTMULTIPLIER":
                    return objImprovementAdder.skillcategorykarmacostmultiplier;
                case "SKILLCATEGORYSPECIALIZATIONKARMACOSTMULTIPLIER":
                    return objImprovementAdder.skillcategoryspecializationkarmacostmultiplier;
                case "ATTRIBUTEPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.attributepointcostmultiplier;
                case "ACTIVESKILLPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.activeskillpointcostmultiplier;
                case "SKILLGROUPPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.skillgrouppointcostmultiplier;
                case "KNOWLEDGESKILLPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.knowledgeskillpointcostmultiplier;
                case "SKILLGROUPCATEGORYPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.skillgroupcategorypointcostmultiplier;
                case "SKILLCATEGORYPOINTCOSTMULTIPLIER":
                    return objImprovementAdder.skillcategorypointcostmultiplier;
                case "NEWSPELLKARMACOSTMULTIPLIER":
                    return objImprovementAdder.newspellkarmacostmultiplier;
                case "NEWCOMPLEXFORMKARMACOSTMULTIPLIER":
                    return objImprovementAdder.newcomplexformkarmacostmultiplier;
                case "NEWAIPROGRAMKARMACOSTMULTIPLIER":
                    return objImprovementAdder.newaiprogramkarmacostmultiplier;
                case "NEWAIADVANCEDPROGRAMKARMACOSTMULTIPLIER":
                    return objImprovementAdder.newaiadvancedprogramkarmacostmultiplier;
                case "BLOCKSKILLSPECIALIZATIONS":
                    return objImprovementAdder.blockskillspecializations;
                case "BLOCKSKILLCATEGORYSPECIALIZATIONS":
                    return objImprovementAdder.blockskillcategoryspecializations;
                case "FOCUSBINDINGKARMACOST":
                    return objImprovementAdder.focusbindingkarmacost;
                case "FOCUSBINDINGKARMAMULTIPLIER":
                    return objImprovementAdder.focusbindingkarmamultiplier;
                case "MAGICIANSWAYDISCOUNT":
                    return objImprovementAdder.magicianswaydiscount;
                case "BURNOUTSWAY":
                    return objImprovementAdder.burnoutsway;
                case "ADDWARE":
                    return objImprovementAdder.addware;
                case "WEAPONACCURACY":
                    return objImprovementAdder.weaponaccuracy;
                case "WEAPONSKILLACCURACY":
                    return objImprovementAdder.weaponskillaccuracy;
                case "METAGENETICLIMIT":
                    return objImprovementAdder.metageneticlimit;
                case "NATURALWEAPON":
                    return objImprovementAdder.naturalweapon;
                case "SINLEVEL":
                    return objImprovementAdder.sinlevel;
                case "MULTIPLESKILLS":
                    return objImprovementAdder.multipleskills;
                // No method matches, return a null pointer
                default:
                    return null;
            }
        }
    }
}
